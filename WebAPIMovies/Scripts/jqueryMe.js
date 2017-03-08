$().ready(function () {
    $("#movieBTN").click(function () {
        $.get("http://localhost:55584/api/movie", function (disp) {
            console.log(disp);
            renderMovie(disp);
        });

    });
    function renderMovie(movieData) {
        var disp = $("#movieTitle");
        disp.empty();
        for (movie in movieData) {
            var title = movieData[movie].Name;
            disp.append("<tr><td>" + title + "</td></tr>");
        }
    }

    /////////
    $("#reviewBTN").click(function () {
        $.get("http://localhost:55584/api/review", function (disp) {
            console.log(disp);
            renderReview(disp);
        });
    });
    function renderReview(ReviewData) {
        var disp = $("#movieReview");
        disp.empty();
        for (Review in ReviewData) {
            var review = ReviewData[Review].ReviewText;
            var movie = ReviewData[Review].Movie.Name;
            
            disp.append("<tr><td>" + review + "</td><td>" + movie + "</td></tr>");
        }
    }
    /////////
    $("#userBTN").click(function () {
        $.get("http://localhost:55584/api/user", function (disp) {
            console.log(disp);
            renderUser(disp);
        });
    });
    function renderUser(UserData) {
        var disp = $("#userTBL");
        disp.empty();
        for (user in UserData) {
            var name = UserData[user].Name;
            var prof = UserData[user].Profession;

            disp.append("<tr><td>" + name + "</td><td>" + prof + "</td></tr>");
        }
    }
});
