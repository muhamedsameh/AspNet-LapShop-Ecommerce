var ClsSittings = {
    GetAll: function () {
        Helper.AjaxCallGet("https://localhost:7079/api/Sitttings", {}, "json",
            function (data) {
                var htmlAllItems = "";

                for (var i = 0; i < data.data.length; i++) {
                    var htmlItem = ClsItems.DrawItem(data.data[i]);
                    htmlAllItems += htmlItem;
                }

                // change inner html of itemArea elemnt
                $("#ItemsArea").html(htmlAllItems);

            }, function () { console.log("failed"); })
    }
}