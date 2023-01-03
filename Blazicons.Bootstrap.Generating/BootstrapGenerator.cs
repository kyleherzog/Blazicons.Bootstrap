using Blazicons.Generating;
using Microsoft.CodeAnalysis;
using Microsoft.VisualStudio.Threading;

namespace Blazicons.Bootstrap.Generating;

[Generator]
internal class BootstrapGenerator : ISourceGenerator
{
    public void Execute(GeneratorExecutionContext context)
    {
        using var taskContext = new JoinableTaskContext();
        var taskFactory = new JoinableTaskFactory(taskContext);
        var downloader = new RepoDownloader(new Uri(Properties.Resources.DownloadAddress));
        taskFactory.Run(
            async () =>
            {
                await downloader.Download(@"^icons\/.*.svg$").ConfigureAwait(true);
            });

        var svgFolder = Path.Combine(downloader.ExtractedFolder, $"{downloader.RepoName}-{downloader.BranchName}", "icons");
        context.WriteIconsClass("BootstrapIcon", svgFolder);

        downloader.CleanUp();
    }

    public void Initialize(GeneratorInitializationContext context)
    {
        // required by ISourceGenerator
    }
}