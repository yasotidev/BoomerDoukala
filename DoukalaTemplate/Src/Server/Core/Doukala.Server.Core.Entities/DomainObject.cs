using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Doukala.Server.Core.Entities
{
    public class DomainObject : IValidatableObject
    {

        public int Id { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] RowVersion { get; set; }
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (false)
#pragma warning disable 162
            {
                yield return new ValidationResult("Oups, ceci ne devrait pas se produire...!");
            }
#pragma warning restore 162
        }
    }
}