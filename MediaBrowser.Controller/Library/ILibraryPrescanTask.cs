﻿using System;
using System.Threading;
using System.Threading.Tasks;

namespace MediaBrowser.Controller.Library
{
    /// <summary>
    /// An interface for tasks that run prior to the media library scan
    /// </summary>
    public interface ILibraryPrescanTask
    {
        /// <summary>
        /// Runs the specified progress.
        /// </summary>
        /// <param name="progress">The progress.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>Task.</returns>
        Task Run(IProgress<double> progress, CancellationToken cancellationToken);
    }
}
