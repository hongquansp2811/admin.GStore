using Admin.DTOs;
using Admin.DTOs.UserDTOs;
using Admin.Models;
using Admin.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Admin.Services
{
    public interface IUserService
    {
        bool CreateUser(UserDto userDto);
        List<User> GetAllUsers();
        UserDto GetUserDTOById(int id);
        bool DeleteUserById(int id);
        bool UpdateUser(UserDto user);
    }

    public class UserService : IUserService
    {
        private IUserRepository _userRepository;
        public UserService()
        {
            this._userRepository = new UserRepository();
        }
        public bool CreateUser(UserDto userDto)
        {
            if (!_userRepository.GetUser().Any(x => x.UserName.Equals(userDto.UserName)))
            {
                var entity = new User()
                {
                    UserName = userDto.UserName,
                    FullName = userDto.FullName,
                    Password = userDto.Password,
                    Email = userDto.UserName,
                    Address = userDto.UserName,
                    Phone = userDto.Phone,
                    Gender = userDto.Gender,
                    Status = userDto.Status,
                    Access = userDto.Access,
                };
                _userRepository.Add(entity);
                return true;
            }else return false;
        }

        public List<User> GetAllUsers()
        {
            return _userRepository.GetUser().Where(x => x.DeletedAt == null).ToList();
        }

        public UserDto GetUserDTOById(int id)
        {
            var current =  _userRepository.GetById(id);
            UserDto userDto = new UserDto()
            {
                Id = id,
                UserName = current.UserName,
                FullName= current.FullName,
                Email = current.Email,
                Address = current.Address,
                Phone = current.Phone,
                Gender = current.Gender,
            };
            return userDto;
        }

        public bool DeleteUserById(int id)
        {
            var current = _userRepository.GetById(id);
            if (current != null)
            {
                current.DeletedAt = DateTime.Now;
                _userRepository.SaveChanges();
                return true;
            }
            else 
                return false; 
        }

        public bool UpdateUser(UserDto userDTO)
        {
            var current = _userRepository.GetById(userDTO.Id);
            if (current != null)
            {
                current.Address = userDTO.Address;  
                current.Phone = userDTO.Phone;  
                current.Gender = userDTO.Gender;    
                current.FullName = userDTO.FullName;
                current.Email = userDTO.Email;
                current.Status = userDTO.Status;
                _userRepository.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}