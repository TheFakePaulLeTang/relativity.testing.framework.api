﻿using Relativity.Testing.Framework.Api.Models;
using Relativity.Testing.Framework.Models;

namespace Relativity.Testing.Framework.Api.Strategies
{
	/// <summary>
	/// Represents the strategy of creating batches.
	/// </summary>
	internal interface ICreateBatchesStrategy
	{
		/// <summary>
		/// Runs create batches operation for a specific batch set.
		/// </summary>
		/// <param name="workspaceId">The Artifact ID of a workspace.</param>
		/// <param name="entityId">The Artifact ID of a batch set.</param>
		/// <param name="userCredentials">User credentials to be used when perfroming action over Relativity Api.</param>
		/// <returns>>The <see cref="BatchProcessResult"/> entity.</returns>
		BatchProcessResult CreateBatches(int workspaceId, int entityId, UserCredentials userCredentials = null);
	}
}
