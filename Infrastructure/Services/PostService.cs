


using Domain.Models;

namespace Infrastructure.Setvices
{

    public class PostSetvice
    {
        private List<Post> Posts;

        public PostSetvice()
        {
            Posts = new List<Post>();
        }
        public List<Post> GetPosts()
        {
            return Posts;
        }
        public void AddPost(Post post)
        {
            Posts.Add(post);
        }
        public void UpdatePost(Post post)
        {
            var find = Posts.FirstOrDefault(x => x.Id ==post.Id);
            if (find != null )
            {
                find.Title = post.Title;
                find.CreatedAt = post.CreatedAt;
                find.Description = post.Description;
            }
        }
        public void Delete(int id)
        {
            var find = Posts.FirstOrDefault(x => x.Id == id);
            Posts.Remove(find);
        }
    }
}