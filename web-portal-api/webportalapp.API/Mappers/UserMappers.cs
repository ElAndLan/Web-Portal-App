using webportalapp.API.Dtos.User;
using webportalapp.Domain.Entities;

namespace webportalapp.API.Mappers
{
    public static class UserMappers
    {
        public static UserDto ToUserDto(this User userModel)
        {
            return new UserDto
            {
                UID = userModel.UID,
                Username = userModel.Username,
                Email = userModel.Email
            };
        }

        public static User ToUserFromCreateDto(this CreateUserRequestDto userDto)
        {

            return new User
            {
                Username = userDto.Username,
                Password = userDto.Password,
                Email = userDto.Email
            };
        }
    }
}
