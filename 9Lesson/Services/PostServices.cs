using _9Lesson.Models;

namespace _9Lesson.Services
{
    public class PostSerices
    {
        private List<Post> posts;

        public PostSerices()
        {
            posts = new List<Post>();
        }

        public Post AddPost(Post Post)
        {
            Post.Id = Guid.NewGuid();
            posts.Add(Post);

            return Post;
        }

        public Post GetPostById(Guid postId)
        {
            foreach (var post in posts)
            {
                if (post.Id == postId)
                {
                    return post;
                }
            }

            return null;
        }
        public bool DeletePost(Guid postId)
        {
            var postFromDb = GetPostById(postId);

            if (postFromDb is null)
            {
                return false;
            }

            posts.Remove(postFromDb);
            return true;
        }
        public bool UpdatePost(Post updatingPost)
        {
            var carFromDb = GetPostById(updatingPost.Id);

            if (carFromDb is null)
            {
                return false;
            }

            var index = posts.IndexOf(carFromDb);
            posts[index] = updatingPost;

            return true;
        }
        public List<Post> GetAllPosts()
        {
            return posts;
        }
        public Post GetMostViewedPost()
        {
            Post mostViewedPost = null;
            var mostVieWed = 0;
            foreach (var post in posts)
            {
                if (post.ViewerNames.Count > mostVieWed)
                {
                    mostViewedPost = post;
                }
            }
            return mostViewedPost;
        }
        public Post GetMostLikedPost()
        {
            Post mostLikePost = null;
            var mostLike = 0;
            foreach (var post in posts)
            {
                if (post.QuantityLikes > mostLike)
                {
                    mostLikePost = post;
                }
            }
            return mostLikePost;
        }
        public Post GetMostCommentedPost()
        {
            Post mostCommentedPost = null;
            var mostComment = 0;
            foreach (var post in posts)
            {
                if (post.Comments.Count > mostComment)
                {
                    mostComment = post.ViewerNames.Count;
                    mostCommentedPost = post;
                }
            }

            return mostCommentedPost;
        }
        public List<Post> GetPostsByComment(string comment)
        {
            var ComnetdetPosts = new List<Post>();
            foreach (var post in posts)
            {
                var comments = post.Comments;
                if (comment.Contains(comment) is true)
                {
                    ComnetdetPosts.Add(post);
                }
            }

            return ComnetdetPosts;
        }
    }
}

