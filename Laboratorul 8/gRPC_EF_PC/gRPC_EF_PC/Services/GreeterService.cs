using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;

namespace gRPC_EF_PC
{
    public class GreeterService : Greeter.GreeterBase
    {
        private readonly ILogger<GreeterService> _logger;
        public List<Comment> comments = new List<Comment>();
        public List<Post> posts = new List<Post>();

        public class Comment {
            public string post;
            public string text;
        }

        public class Post{
            public string description;
            public string domain;
            public string dateTime;
        }

        public GreeterService(ILogger<GreeterService> logger)
        {
            _logger = logger;
        }

        public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
        {
            return Task.FromResult(new HelloReply
            {
                Message = "Hello " + request.Name
            });
        }

        public override Task<AddPostReply> AddPost(AddPostRequest request, ServerCallContext context)
        {
            Post post = new Post()
            {
                description = request.Description,
                domain = request.Domain,
                dateTime = request.DateTime
            };
            posts.Add(post);

            return Task.FromResult(new AddPostReply
            {
                Message = "Your post \"" + request.Description +"\" was added."
            });

        }

        public override Task<AddCommentReply> AddComment(AddCommentRequest request,ServerCallContext context)
        {
            Comment comment = new Comment();
            comment.text = request.Comment;
            comment.post = request.Post;
            comments.Add(comment);

            return Task.FromResult(new AddCommentReply
            {
                Message = "Your Comment is \"" + request.Comment + "\" for  \"" + request.Post + "\" post."
            });
        }

        public override Task<GetCommentsByPostReply> GetCommentsByPost(GetCommentsByPostRequest request, ServerCallContext context)
        {

            String return_message = "Comments for \"" + request.Post + "\": \n";

            foreach(Comment comment in comments)
            {
                if(comment.post == request.Post)
                {
                    return_message += comment.text + "\n";
                }
            }

            return Task.FromResult(new GetCommentsByPostReply
            {
                Message = return_message
            });
        }




    }
}
