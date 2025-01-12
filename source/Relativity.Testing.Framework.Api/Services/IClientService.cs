﻿using Relativity.Testing.Framework.Models;
using Relativity.Testing.Framework.Strategies;

namespace Relativity.Testing.Framework.Api.Services
{
	/// <summary>
	/// Represents the client API service.
	/// </summary>
	/// <example>
	/// <code>
	/// _clientService = relativityFacade.Resolve&lt;IClientService&gt;();
	/// </code>
	/// </example>
	public interface IClientService
	{
		/// <summary>
		/// Creates the specified client.
		/// </summary>
		/// <param name="entity">The <see cref="Client"/> to create.</param>
		/// <returns>The created client.</returns>
		/// <example>
		/// Create any old client.
		/// <code>
		/// Client client = _clientService.Create(Client());
		/// </code>
		/// </example>
		/// <example>
		/// Create a client with specified properties.
		/// <code>
		/// Client client = new Client
		/// {
		///     Name = "TheBigClient",
		///     Number = 12345,
		///     Status = new NamedArtifact { Name = ClientStatus.Inactive.ToString() },
		///     Keywords = "SomeKeyword"
		///     Notes = "Some note about the client."
		/// };
		/// client = _clientService.Create(client);
		/// </code>
		/// </example>
		Client Create(Client entity);

		/// <summary>
		/// Updates the specified <see cref="Client"/>.
		/// </summary>
		/// <param name="entity">The <see cref="Client"/> model to use to update the existing client with.</param>
		/// <example>
		/// <code>
		/// Client client = _clientService.Get("Some Client Name");
		/// client.Keywords = "SampleKeywords";
		/// _clientService.Update(client);
		/// </code>
		/// </example>
		void Update(Client entity);

		/// <summary>
		/// Requires the specified client.
		/// <list type="number">
		/// <item>If the <see cref="Artifact.ArtifactID"/> property of <paramref name="entity"/> has a positive value, this gets the client by ID and returns it.</item>
		/// <item>Else if the <see cref="NamedArtifact.Name"/> property of <paramref name="entity"/> has a value, this gets the client by name and returns it if it exists.</item>
		/// <item>Otherwise this creates a new client using <see cref="ICreateStrategy{T}"/>.</item>
		/// </list>
		/// </summary>
		/// <param name="entity">The <see cref="Client"/> to require.</param>
		/// <returns>The already existing, or created <see cref="Client"/>.</returns>
		/// <example>
		/// <para>This example will search for a client with the ArtifactID "1234567".</para>
		/// <para>If it is found, it will be returned.</para>
		/// <para>If not, it will be created.</para>
		/// <code>
		/// Client client = new Client
		/// {
		///     ArtifactID = 1234567
		/// };
		/// client = _clientService.Require(client);
		/// </code>
		/// </example>
		/// <example>
		/// <para>This example will search for a client named "MyClient".</para>
		/// <para>If one is found, it will be returned.</para>
		/// <para>If not, it will be created.</para>
		/// <code>
		/// Client client = new Client
		/// {
		///     Name = "MyClient"
		/// };
		/// client = _clientService.Require(client);
		/// </code>
		/// </example>
		Client Require(Client entity);

		/// <summary>
		/// Deletes the <see cref="Client"/> by ID.
		/// </summary>
		/// <param name="id">The ArtifactID of the client.</param>
		/// <example>
		/// <code>
		/// _clientService.Delete(client.ArtifactID);
		/// </code>
		/// </example>
		void Delete(int id);

		/// <summary>
		/// Gets the <see cref="Client"/> by ArtifactID.
		/// </summary>
		/// <param name="id">The ArtifactID of the client.</param>
		/// <returns>The <see cref="Client"/> if it exists, else <see langword="null"/>.</returns>
		/// <example>
		/// <code>
		/// Client client = _clientService.Get(1234567);
		/// </code>
		/// </example>
		Client Get(int id);

		/// <summary>
		/// Gets the <see cref="Client"/> by name.
		/// </summary>
		/// <param name="name">The name of the client.</param>
		/// <returns>The <see cref="Client"/> if it exists, else <see langword="null"/>.</returns>
		/// <example>
		/// <code>
		/// Client client = _clientService.Get("AnotherClient");
		/// </code>
		/// </example>
		Client Get(string name);
	}
}
