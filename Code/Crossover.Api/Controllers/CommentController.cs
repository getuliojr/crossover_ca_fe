﻿using System.Web.Http;
using MediatR;
using Crossover.Commands.CommentCommands.Command;
using Crossover.Queries.CommentQueries.Query;
using Crossover.Api.Hubs;

namespace Crossover.Api.Controllers
{

    [RoutePrefix("api/comment")]
    [Authorize]
    public class CommentController : HubApiController<ApiHub>
    {

        private readonly IMediator _mediator;
        public CommentController(IMediator mediator)
        {
            _mediator = mediator;
        }

        //Create New
        [Route("")]
        public IHttpActionResult PostComment([FromBody]CreateCommentCommand command)
        {
            var response = _mediator.Send(command);
            return Ok(response);
        }

        //Get one Comment by ID
        [Route("{id:int}")]
        public IHttpActionResult GetComment(int id)
        {
            var query = new CommentByIdQuery
            {
                intIdComment = id
            };

            var response = _mediator.Send(query);

            return Ok(response);
        }

        //Update one Comment
        [Route("{id:int}")]
        public IHttpActionResult PutComment(int id, [FromBody]UpdateCommentCommand command)
        {
            command.intIdComment = id;
            var resposta = _mediator.Send(command);
            return Ok(resposta);
        }
        
        //Delete a Comment 
        [Route("{id:int}")]
        public IHttpActionResult DeleteComment(int id)
        {
            var command = new DeleteCommentCommand { intIdComment = id };
            _mediator.Send(command);
            return Ok(command);
        }
    }
}
