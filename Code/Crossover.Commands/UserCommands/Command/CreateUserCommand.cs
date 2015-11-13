﻿using System.ComponentModel.DataAnnotations;
using MediatR;
using Crossover.Domain.Entities;

namespace Crossover.Commands.UserCommands.Command 
{
    public class CreateUserCommand : IRequest<User>
    {
        [Required(ErrorMessage = "the user fullname is required!")]
        public string strFullName { get; set; }

        [Required(ErrorMessage = "The user e-mail is required!")]
        public string strEmail { get; set; }

        [Required(ErrorMessage = "The user password is required!")]
        public string strPassword { get; set; }

      
    }
}
