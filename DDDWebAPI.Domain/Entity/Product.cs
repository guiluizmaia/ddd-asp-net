using System;
using DDDWebAPI.Domain.Exceptions;


namespace DDDWebAPI.Domain.Entity
{
    public class Product
    {
        public string Id { get; private set; }
        public string Name { get; private set; }
        public decimal Value { get; private set; }
        public bool Active { get; private set; }
        public string ClientId { get; private set; }
        public virtual Client Client { get; private set; }

        public Product(string name, decimal value, string clientId, bool? active = true, string? id = Guid.NewGuid().ToString()){
            Id = id
            Name = name
            Value = value
            ClientId = clientId
            Active = active

            Validate()
        }

        public void Activate()
        {
            Active = true;
            Validate();
        }

        public void Deactivate()
        {
            Active = false;
            Validate();
        }


        private void Validate()
        {
            DomainValidation.NotNullOrEmpty(Id, nameof(Id));
            DomainValidation.MinLength(Id, 36, nameof(Id));
            DomainValidation.MaxLength(Id, 36, nameof(Id));

            DomainValidation.NotNullOrEmpty(Name, nameof(Name));
            DomainValidation.MinLength(Name, 3, nameof(Name));
            DomainValidation.MaxLength(Name, 255, nameof(Name));

            DomainValidation.NotNullOrEmpty(Value, nameof(Value));

            DomainValidation.NotNullOrEmpty(Active, nameof(Active));

            DomainValidation.NotNullOrEmpty(ClientId, nameof(ClientId));
        }
    }
}
