using Blogy.Business.DTOs.BlogDtos;
using Blogy.Business.DTOs.Common;
using Blogy.Business.DTOs.UserDtos;

namespace Blogy.Business.DTOs.CommentDtos
{
    public class UpdateCommentDto : BaseDto
    {
        public string? Content { get; set; }
        public int BlogId { get; set; }
        public int UserId { get; set; }
    }
}
