var ClsSittings = {
    GetAll: function () {
        Helper.AjaxCallGet("https://localhost:7079/api/Sitttings", {}, "json",
            function (data) {

                $("#lnkFacebook").attr("href", data.facebookLink);
                $("#lnkYoutupe").attr("href", data.youtubeLink);
                $("#lnkX").attr("href", data.xLink);
                $("#lnkInsta").attr("href", data.instaLink);
                $("#lnkLinkedin").attr("href", data.linkedinLink);

                document.getElementById("phonenumber").innerText = data.phoneNumber;
                document.getElementById("location").innerText = data.location;
                document.getElementById("email").innerText = data.email;
                document.getElementById("dis").innerText = data.discription.replace(/\./g, '.\n'); // add new line before each dot.

            }, function () { console.log("failed"); })
    }
}

ClsSittings.GetAll();