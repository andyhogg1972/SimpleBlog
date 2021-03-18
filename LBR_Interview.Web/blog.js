$( document ).ready(function() {
  
  var blogObj = {

    render: function(){
      var that = this;
      const endpoint = 'https://localhost:44339/api/blogposts'
      $.ajax({
        url: endpoint,
        contentType: "application/json",
        dataType: 'json',
        success: function(result){
          that.renderPost(result);
          that.events();
        }
    });
    },

    renderPost: function(posts){
      var that = this;
      var blog = $("#blogPosts");
      $.each(posts.Posts, function(id, post){ 
       
        blog.after(`<div class="blogpost" style="padding: 8px 0px;">
        <div><span tabindex="0"
                style="border: 10px; box-sizing: border-box; display: block; font-family: Roboto, sans-serif; -webkit-tap-highlight-color: rgba(0, 0, 0, 0); cursor: pointer; text-decoration: none; margin: 0px; padding: 0px; outline: none; font-size: 16px; font-weight: inherit; position: relative; color: rgba(0, 0, 0, 0.87); line-height: 16px; transition: all 450ms cubic-bezier(0.23, 1, 0.32, 1) 0ms; background: none;">
                <div>
                    <div style="margin-left: 0px; padding: 16px; position: relative;">
                        <article style="line-height: 1.35;">
                            <h2><strong>`+post.Title+`</strong></h2>
                            <p class="body">`+post.Body+`</p>
                            <div style="text-align: right;"><time
                                    datetime="`+post.PublishedOn+`">Comments: `+post.CommentCount+`</time></div>
                        </article>
                    </div>
                </div>
            </span></div>
    <hr style="margin: -1px 0px 0px; height: 1px; border: none; background-color: rgb(224, 224, 224);">
    </div>`);
      });

      $('p').hide();
    },

    events: function(){
      //click post event to toggle body view or not.
      $(".blogpost").click(function(){
        $(this).find('p').toggle();
      });
    }

  }

  blogObj.render();

});

