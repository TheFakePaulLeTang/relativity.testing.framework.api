﻿using Relativity.Testing.Framework.Models;

namespace Relativity.Testing.Framework.Api.Services
{
	/// <summary>
	/// Represents the NativeType API service.
	/// </summary>
	/// <example>
	/// <code>
	/// _imagingNativeTypeService = relativityFacade.Resolve&lt;IImagingNativeTypeService&gt;();
	/// </code>
	/// </example>
	public interface IImagingNativeTypeService
	{
		/// <summary>
		/// Retrieves the <see cref="NativeType"/> with the specified Artifact ID.
		/// </summary>
		/// <param name="workspaceId">The workspace ID.</param>
		/// <param name="nativeTypeId">The Artifact ID of the <see cref="NativeType"/> instance to read.</param>
		/// <returns>Returns an <see cref="NativeType"/> instance.</returns>
		/// <example>
		/// <code>
		/// var workspaceId = 1015427;
		/// var nativeTypeId = 1018877;
		/// var nativeType = _imagingNativeTypeService.Get(workspaceId, nativeTypeId);
		/// </code>
		/// </example>
		NativeType Get(int workspaceId, int nativeTypeId);
	}
}
