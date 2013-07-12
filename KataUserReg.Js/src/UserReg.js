var validator = {
  userNameExists: function(){
    return $('#name').val().length > 0;
  },

    validate: function()
    {
        if (!validator.userNameExists())
        {
            validator.markAsMissing("#name");
        }
    },

    markAsMissing: function(selector)
    {
        $(selector).addClass("valueIsMissing");
    }

};
