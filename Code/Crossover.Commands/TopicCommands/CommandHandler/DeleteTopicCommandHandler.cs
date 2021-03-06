﻿using System;
using System.Data.Entity;
using MediatR;
using AutoMapper;
using Crossover.Domain.Entities;
using Crossover.Utils.Security;
using Crossover.Commands.TopicCommands.Command;

namespace Crossover.Commands.TopicCommands.CommandHandler
{
    public class DeleteTopicCommandHandler : RequestHandler<DeleteTopicCommand>
    {
        private readonly DbContext _dbContext;

        public DeleteTopicCommandHandler(DbContext context)
        {
            _dbContext = context;
        }

        protected override void HandleCore(DeleteTopicCommand command)
        {
            var entity = Mapper.Map<Topic>(command);
            _dbContext.Set<Topic>().Attach(entity);

            //Set it as deleted
            _dbContext.Entry(entity).State = EntityState.Deleted;
            _dbContext.SaveChanges();
        }
    }
}
