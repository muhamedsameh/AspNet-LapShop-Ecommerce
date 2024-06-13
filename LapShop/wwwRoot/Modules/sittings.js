var ClsSittings = {
    GetAll: function () {
        Helper.AjaxCallGet("https://localhost:7079/api/Sitttings", {}, "json",
            function (data) {
                console.log(data);
                console.log(data.data);
                console.log(data.FacebookLink);
                $("#lnkFacebook").attr("href", data.data.FacebookLink);
                $("#lnkYoutupe").attr("href", data.data.lnkYoutupe);
                $("#lnkX").attr("href", data.data.XLink);
                $("#lnkInsta").attr("href", data.data.InstaLink);
                $("#lnkLinkedin").attr("href", data.data.LinkedinLink);

            }, function () { console.log("failed"); })
    }
}

ClsSittings.GetAll();