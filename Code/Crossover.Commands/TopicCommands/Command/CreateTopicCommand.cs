﻿using System.ComponentModel.DataAnnotations;
using MediatR;
using Crossover.Domain.Entities;

namespace Crossover.Commands.TopicCommands.Command 
{
    public class CreateTopicCommand : IRequest<Topic>
    {
        [Required(ErrorMessage = "The tile of the topic is required!")]
        public string strTitle { get; set; }

        [Required(ErrorMessage = "The description/information of the topic is required!")]
        public string txtDescription { get; set; }
      
    }
}
