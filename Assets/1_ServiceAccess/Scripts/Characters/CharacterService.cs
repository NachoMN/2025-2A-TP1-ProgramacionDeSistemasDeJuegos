using System.Collections.Generic;
using UnityEngine;

namespace Excercise1
{
    public class CharacterService : MonoBehaviour
    {
        private readonly Dictionary<string, ICharacter> _charactersById = new();
        public bool TryAddCharacter(string id, ICharacter character)
            => _charactersById.TryAdd(id, character);
        public bool TryRemoveCharacter(string id)
            => _charactersById.Remove(id);

        //Obtengo el Charchater segun el "id"
        public ICharacter GetCharacterById(string id)
        {
            _charactersById.TryGetValue(id, out var character);
            return character;
        }
    }
}
