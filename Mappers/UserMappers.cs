using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using wastemanagementapi.Dtos.User;
using wastemanagementapi.Models;

namespace wastemanagementapi.Mappers
{
    public static class UserMappers
    {
        public static UserResponseDTO ToUserResponseDTO(this User userModel)
        {
            return new UserResponseDTO
            {
                Id = userModel.Id,
                FullName = userModel.FullName,
                Email = userModel.Email,
                PhoneNumber = userModel.PhoneNumber,
                UserType = userModel.UserType,
                IsVerified = userModel.IsVerified,
                Status = userModel.Status,
                Partner = userModel.Partner,
                CreatedAt = userModel.CreatedAt,
                UpdatedAt = userModel.UpdatedAt
            };
        }
    }
}