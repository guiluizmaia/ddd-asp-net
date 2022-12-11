using System;
using DDDWebAPI.Domain.Exceptions;

namespace DDDWebAPI.Domain.Entity
{
    public class Client
    {
        public string Id { get; private set; }
        public string Name { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public bool Active { get; private set; }

        public Client(string name, string lastName, string email, DateTime createdAt, string? id = Guid.NewGuid().ToString(), bool? active = true){
            Id = id;
            Name = name;
            LastName = lastName;
            Email = email;
            CreatedAt = createdAt;
            Active = active;

            Validar()
        }

        public void Ativar()
        {
            Active = true;
            Validar();
        }

        public void Desativar()
        {
            Active = false;
            Validar();
        }


        private void Validar()
        {
            DomainValidation.NotNullOrEmpty(Id, nameof(Id));
            DomainValidation.MinLength(Id, 36, nameof(Id));
            DomainValidation.MaxLength(Id, 36, nameof(Id));

            DomainValidation.NotNullOrEmpty(Name, nameof(Name));
            DomainValidation.MinLength(Name, 3, nameof(Name));
            DomainValidation.MaxLength(Name, 255, nameof(Name));

            DomainValidation.NotNullOrEmpty(LastName, nameof(LastName));
            DomainValidation.MinLength(LastName, 3, nameof(LastName));
            DomainValidation.MaxLength(LastName, 255, nameof(LastName));
            
            DomainValidation.NotNullOrEmpty(Email, nameof(Email));
            DomainValidation.MinLength(Email, 5, nameof(Email));
            DomainValidation.MaxLength(Email, 50, nameof(Email));

            DomainValidation.NotNullOrEmpty(CreatedAt, nameof(CreatedAt));

            DomainValidation.NotNullOrEmpty(Active, nameof(Active));

        }
    }


}
