using System;
using System.ComponentModel;
using System.Net.Http;
using System.Threading.Tasks;
using Grpc.Net.Client;
using gRPC_EF_PC;

namespace GrpcGreeterClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // The port number(5001) must match the port of the gRPC server.
            using var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new Greeter.GreeterClient(channel);
            var reply = await client.SayHelloAsync( new HelloRequest { Name = "Client" });
            Console.WriteLine("Greeting: " + reply.Message);

            var reply_post = await client.AddPostAsync(
                new AddPostRequest
                {
                    Description = "University status",
                    Domain = "Education",
                    DateTime = "28.04.2020"
                });
            Console.WriteLine("Add comment respons: " + reply_post.Message);

            var reply_comm = await client.AddCommentAsync(
                new AddCommentRequest { 
                    Comment = "How it's gonna be with the exams ?", 
                    Post = "University status"
                });
            Console.WriteLine("Add comment respons: " + reply_comm.Message);

            var get_comment = await client.GetCommentsByPostAsync(
                new GetCommentsByPostRequest
                {
                    Post = "University status"
                }
            );
            Console.WriteLine("Get comment respons: " + get_comment.Message);

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
