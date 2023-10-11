using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using TestMVC.MvcEduModels;

namespace TestMVC.Models
{
    public class Login
    {
        public Login()
        {
            Account = string.Empty;
            Password = string.Empty;
        }
        [Required(ErrorMessage ="  * Please enter your Account!")]
        [Display(Name ="Account")]
        public string Account {  get; set; }
        [Required(ErrorMessage ="  * Please enter your Password!")]
        [DataType(DataType.Password)]
        [Display(Name ="Password")]
        public string Password { get; set; }

        [Display(Name = "Summary")]
        public string Summary { get; set; }
    }


public static class MemberEndpoints
{
	public static void MapMemberEndpoints (this IEndpointRouteBuilder routes)
    {
        routes.MapGet("/api/Member", async (MvcEduContext db) =>
        {
            return await db.Members.ToListAsync();
        })
        .WithName("GetAllMembers")
        .Produces<List<Member>>(StatusCodes.Status200OK);

        routes.MapGet("/api/Member/{id}", async (int ID, MvcEduContext db) =>
        {
            return await db.Members.FindAsync(ID)
                is Member model
                    ? Results.Ok(model)
                    : Results.NotFound();
        })
        .WithName("GetMemberById")
        .Produces<Member>(StatusCodes.Status200OK)
        .Produces(StatusCodes.Status404NotFound);

        routes.MapPut("/api/Member/{id}", async (int ID, Member member, MvcEduContext db) =>
        {
            var foundModel = await db.Members.FindAsync(ID);

            if (foundModel is null)
            {
                return Results.NotFound();
            }

            db.Update(member);

            await db.SaveChangesAsync();

            return Results.NoContent();
        })
        .WithName("UpdateMember")
        .Produces(StatusCodes.Status404NotFound)
        .Produces(StatusCodes.Status204NoContent);

        routes.MapPost("/api/Member/", async (Member member, MvcEduContext db) =>
        {
            db.Members.Add(member);
            await db.SaveChangesAsync();
            return Results.Created($"/Members/{member.ID}", member);
        })
        .WithName("CreateMember")
        .Produces<Member>(StatusCodes.Status201Created);


        routes.MapDelete("/api/Member/{id}", async (int ID, MvcEduContext db) =>
        {
            if (await db.Members.FindAsync(ID) is Member member)
            {
                db.Members.Remove(member);
                await db.SaveChangesAsync();
                return Results.Ok(member);
            }

            return Results.NotFound();
        })
        .WithName("DeleteMember")
        .Produces<Member>(StatusCodes.Status200OK)
        .Produces(StatusCodes.Status404NotFound);
    }
}}
