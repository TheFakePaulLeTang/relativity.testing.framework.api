﻿using Moq;
using NUnit.Framework;
using Relativity.Testing.Framework.Api.Services;
using Relativity.Testing.Framework.Api.Strategies;
using Relativity.Testing.Framework.Api.Validators;

namespace Relativity.Testing.Framework.Api.Tests.Strategies
{
	[TestFixture]
	[TestOf(typeof(ApplicationFieldCodeGetStrategyV1))]
	public class ApplicationFieldCodeGetStrategyV1Fixture
	{
		private const int _WORKSPACE_ID = 100000;
		private const int _APPLICATION_FIELD_CODE_ID = 100001;

		private ApplicationFieldCodeGetStrategyV1 _sut;
		private Mock<IRestService> _mockRestService;
		private Mock<IWorkspaceIdValidator> _workspaceIdValidator;
		private Mock<IArtifactIdValidator> _artifactIdValidator;

		[SetUp]
		public void SetUp()
		{
			_mockRestService = new Mock<IRestService>();
			_workspaceIdValidator = new Mock<IWorkspaceIdValidator>();
			_artifactIdValidator = new Mock<IArtifactIdValidator>();

			_sut = new ApplicationFieldCodeGetStrategyV1(_mockRestService.Object, _workspaceIdValidator.Object, _artifactIdValidator.Object);
		}

		[Test]
		public void Get_WithAnyInput_ShouldCallValidator()
		{
			_sut.Get(_WORKSPACE_ID, _APPLICATION_FIELD_CODE_ID);
			_workspaceIdValidator.Verify(x => x.Validate(_WORKSPACE_ID), Times.Once);
			_artifactIdValidator.Verify(x => x.Validate(_APPLICATION_FIELD_CODE_ID, "ApplicationFieldCode"), Times.Once);
		}
	}
}
