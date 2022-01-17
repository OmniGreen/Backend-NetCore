using Uzx.Domain.Commands;

namespace Uzx.Domain.Validations
{
     public class RemoveCustomerCommandValidation : CustomerValidation<RemoveCustomerCommand>
    {
        public RemoveCustomerCommandValidation()
        {
            ValidateId();
        }
    }
}