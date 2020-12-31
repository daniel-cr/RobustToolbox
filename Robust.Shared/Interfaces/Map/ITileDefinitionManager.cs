using System.Collections.Generic;
using Robust.Shared.Network.Messages;

namespace Robust.Shared.Interfaces.Map
{
    /// <summary>
    ///     This manages tile definitions for grid tiles.
    /// </summary>
    public interface ITileDefinitionManager : IEnumerable<ITileDefinition>
    {
        /// <summary>
        ///     Indexer to retrieve a tile definition by name.
        /// </summary>
        /// <param name="name">The name of the tile definition.</param>
        /// <returns>The named tile definition.</returns>
        ITileDefinition this[string name] { get; }

        /// <summary>
        ///     Indexer to retrieve a tile definition by internal ID.
        /// </summary>
        /// <param name="id">The ID of the tile definition.</param>
        /// <returns>The tile definition.</returns>
        ITileDefinition this[int id] { get; }

        /// <summary>
        ///     The number of tile definitions contained inside of this manager.
        /// </summary>
        int Count { get; }

        void Initialize();

        /// <summary>
        ///     Register a definition with this manager.
        /// </summary>
        /// <param name="tileDef">The definition to register.</param>
        void Register(ITileDefinition tileDef);

        /// <summary>
        ///     Add base turfs to a lookup list
        /// </summary>
        /// <param name="baseTurf">The base turf to add to the list</param>
        void SetLookUp(string baseTurf);

        /// <summary>
        ///     Gets the tileId of the n base turf of the current tile, where n is the 'steps'
        ///     from the current tile
        /// </summary>
        /// <param name="tileId">The current tileId of the tile definition</param>
        /// <param name="steps">The level of base turf</param>
        /// <returns>The TileId of the n base turf</returns>
        ushort GetBaseTurfId(ushort tileId, int steps=1);

        /// <summary>
        ///     Gets the tile definition of the n base turf of the current tile, where n is the 'steps'
        ///     from the current tile
        /// </summary>
        /// <param name="tileId">The current tileId of the tile definition</param>
        /// <param name="steps">The level of base turf</param>
        /// <returns>The Tile definition of the n base turf</returns>
        ITileDefinition GetBaseTurfTileDef(ushort tileId, int steps=1);

    }
}
