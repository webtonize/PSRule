// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using System.Collections;
using System.Management.Automation;
using PSRule.Pipeline;
using PSRule.Runtime;

namespace PSRule.Definitions.Conventions
{
    internal sealed class ScriptBlockConvention : BaseConvention, IDisposable, IResource
    {
        private readonly LanguageScriptBlock _Initialize;
        private readonly LanguageScriptBlock _Begin;
        private readonly LanguageScriptBlock _Process;
        private readonly LanguageScriptBlock _End;

        private bool _Disposed;

        internal ScriptBlockConvention(
            SourceFile source,
            ResourceMetadata metadata,
            ResourceHelpInfo info,
            LanguageScriptBlock begin,
            LanguageScriptBlock initialize,
            LanguageScriptBlock process,
            LanguageScriptBlock end,
            ActionPreference errorPreference,
            ResourceFlags flags,
            ISourceExtent extent)
            : base(source, metadata.Name)
        {
            Info = info;
            _Initialize = initialize;
            _Begin = begin;
            _Process = process;
            _End = end;
            Flags = flags;
            Extent = extent;
        }

        public IResourceHelpInfo Info { get; }

        public ResourceFlags Flags { get; }

        public ISourceExtent Extent { get; }

        ResourceKind IResource.Kind => ResourceKind.Convention;

        string IResource.ApiVersion => Specs.V1;

        // Not supported with conventions.
        ResourceId? IResource.Ref => null;

        // Not supported with conventions.
        ResourceId[] IResource.Alias => null;

        // Not supported with conventions.
        ResourceTags IResource.Tags => null;

        // Not supported with conventions.
        ResourceLabels IResource.Labels => null;

        public override void Initialize(RunspaceContext context, IEnumerable input)
        {
            InvokeConventionBlock(context, Source, _Initialize, input);
        }

        public override void Begin(RunspaceContext context, IEnumerable input)
        {
            InvokeConventionBlock(context, Source, _Begin, input);
        }

        public override void Process(RunspaceContext context, IEnumerable input)
        {
            InvokeConventionBlock(context, Source, _Process, input);
        }

        public override void End(RunspaceContext context, IEnumerable input)
        {
            InvokeConventionBlock(context, Source, _End, input);
        }

        private static void InvokeConventionBlock(RunspaceContext context, SourceFile source, LanguageScriptBlock block, IEnumerable input)
        {
            if (block == null)
                return;

            try
            {
                context.EnterLanguageScope(source);
                block.Invoke();
            }
            finally
            {
                context.ExitLanguageScope(source);
            }
        }

        #region IDisposable

        private void Dispose(bool disposing)
        {
            if (!_Disposed)
            {
                if (disposing)
                {
                    _Begin?.Dispose();

                    _Process?.Dispose();

                    _End?.Dispose();
                }
                _Disposed = true;
            }
        }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        #endregion IDisposable
    }
}
