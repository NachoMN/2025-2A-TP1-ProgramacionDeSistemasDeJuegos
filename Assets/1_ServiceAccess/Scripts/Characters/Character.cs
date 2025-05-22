using System;
using UnityEngine;

namespace Excercise1
{
    public class Character : MonoBehaviour, ICharacter
    {
        [SerializeField] protected string id;
        protected CharacterService characterService;

        protected virtual void OnEnable()
        {
            //Declaro characaterServise
            //Busco en la Ecensa el objeto que tenga el charachter service
            //Despues lo añado al diccionario  
            GameObject charcacterServiceObject = FindAnyObjectByType<CharacterService>().gameObject;
            characterService = charcacterServiceObject.GetComponent<CharacterService>();
            characterService.TryAddCharacter(id, this);
            //TODO: Add to CharacterService. The id should be the given serialized field. 
        }

        protected virtual void OnDisable()
        {
            //Lo saco del Diccionario
            characterService.TryRemoveCharacter(id);
            //TODO: Remove from CharacterService.
        }
    }
}