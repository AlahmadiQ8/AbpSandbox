﻿using Sanbox.Main.Domain;
using Volo.Abp.Application.Dtos;

namespace Sanbox.Main.Services.Dtos;

public class BookDto : AuditedEntityDto<Guid>
{
    public string Name { get; set; }

    public BookType Type { get; set; }

    public DateTime PublishDate { get; set; }

    public float Price { get; set; }
    
    public Guid AuthorId { get; set; }
    
    public string AuthorName { get; set; }
}