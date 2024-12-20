using MyRecipeBook.Communication.Requests;
using MyRecipeBook.Communication.Responses;

namespace MyRecipeBook.Application.UserCases.User.Register
{
    public class RegisterUserUseCase
    {
        public ResponseRegisteredUserJson Execute(RequestRegisterUserJson request)
        {
            Validator(request);

            // Mapear a request em uma entidade

            // críptografia da senha

            // salvar no banco de dados

            return new ResponseRegisteredUserJson
            {
                Name = request.Name,
            };
        }

        private void Validator(RequestRegisterUserJson request)
        {
            var validator = new RegisterUserValidator();
            var result = validator.Validate(request);

            if(result.IsValid == false)
            {
                var erroMessages = result.Errors.Select(e => e.ErrorMessage);
                    throw new Exception();
            }

        }
    }
}
