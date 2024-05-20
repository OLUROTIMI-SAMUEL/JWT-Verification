using Application.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Contract
{
    public interface IUser
    {

        Task <RegistrationResponse> RegisterUserAsync(RegisterUserDTO  registrationDTO);

        Task<LoginResponse> LoginUserAsync(LoginDTO loginDTO);

    }
}
