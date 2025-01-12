﻿using Relativity.Testing.Framework.Api.Attributes;
using Relativity.Testing.Framework.Api.Strategies;
using Relativity.Testing.Framework.Models;

namespace Relativity.Testing.Framework.Api.Services
{
	[DoNotRetry]
	internal class LibraryApplicationService : ILibraryApplicationService
	{
		private readonly ILibraryApplicationInstallRapStrategy _libraryApplicationInstallRapStrategy;

		private readonly ILibraryApplicationInstallToWorkspaceStrategy _installToWorkspaceStrategy;

		private readonly ILibraryApplicationIsInstalledInWorkspaceStrategy _isInstalledInWorkspaceStrategy;

		private readonly IGetByNameStrategy<LibraryApplication> _getByNameStrategy;

		public LibraryApplicationService(
			ILibraryApplicationInstallRapStrategy libraryApplicationInstallRapStrategy,
			ILibraryApplicationInstallToWorkspaceStrategy installToWorkspaceStrategy,
			ILibraryApplicationIsInstalledInWorkspaceStrategy isInstalledInWorkspaceStrategy,
			IGetByNameStrategy<LibraryApplication> getByNameStrategy)
		{
			_installToWorkspaceStrategy = installToWorkspaceStrategy;
			_isInstalledInWorkspaceStrategy = isInstalledInWorkspaceStrategy;
			_getByNameStrategy = getByNameStrategy;
			_libraryApplicationInstallRapStrategy = libraryApplicationInstallRapStrategy;
		}

		public int InstallToLibrary(string pathToRap, LibraryApplicationInstallOptions options = null)
			=> _libraryApplicationInstallRapStrategy.InstallToLibrary(pathToRap, options);

		public void InstallToWorkspace(int workspaceId, int applicationId)
			=> _installToWorkspaceStrategy.InstallToWorkspace(workspaceId, applicationId);

		public bool IsInstalledInWorkspace(int workspaceId, int applicationId)
			=> _isInstalledInWorkspaceStrategy.IsInstalledInWorkspace(workspaceId, applicationId);

		public LibraryApplication Get(string name)
			=> _getByNameStrategy.Get(name);
	}
}
