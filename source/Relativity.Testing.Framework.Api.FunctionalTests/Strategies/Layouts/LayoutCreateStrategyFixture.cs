﻿using FluentAssertions;
using NUnit.Framework;
using Relativity.Testing.Framework.Api.Strategies;
using Relativity.Testing.Framework.Models;
using Relativity.Testing.Framework.Versioning;

namespace Relativity.Testing.Framework.Api.FunctionalTests.Strategies
{
	[TestOf(typeof(ICreateWorkspaceEntityStrategy<Layout>))]
	[VersionRange(">=12.0")]
	internal class LayoutCreateStrategyFixture : ApiServiceTestFixture<ICreateWorkspaceEntityStrategy<Layout>>
	{
		public LayoutCreateStrategyFixture()
		{
		}

		public LayoutCreateStrategyFixture(string relativityInstanceAlias)
			: base(relativityInstanceAlias)
		{
		}

		[Test]
		public void Create_WithFilledEntity()
		{
			ObjectType objectType = null;

			ArrangeWorkingWorkspace(x => x.Create(out objectType));

			var entity = new Layout
			{
				Name = Randomizer.GetString("AT_"),
				ObjectType = objectType
			};

			var result = Sut.Create(DefaultWorkspace.ArtifactID, entity);

			result.ArtifactID.Should().BePositive();
			result.Should().BeEquivalentTo(entity, o => o.
				Excluding(x => x.ArtifactID));
		}
	}
}
