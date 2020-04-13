var setting = {
    check: {
        //chkboxType: { "Y": "ps", "N": "ps" },
        chkStyle: "checkbox",//复选框类型
        enable: true //每个节点上是否显示 CheckBox
    },
    data: {
        simpleData: {
            enable: true
        }
    },
    callback: {
        //beforeCheck: false,
        onCheck: onCheck,
        //ProductonCheck:ProductonCheck,
    }

};

//var zNodes = [];
//    $.ajax({
//        url: "/Users/DepartmentInfoGet",
//        type: "post",
//        datatype: "json",
//        success: function (res) {
//            $(res.Departments).each(function () {
//                zTree_Id += res.Departments.DepartMentId + ",";
//                zTree_Name += res.Departments.DepartMentName + ",";
//                return zTree_Id;
//                return zTree_Name;
//            })

//            if (zTree_Id.length > 0) {
//                zTree_Id = zTree_Id.substr(0, zTree_Id.length - 1);
//            }
//            if (zTree_Name.length > 0) {
//                zTree_Name = zTree_Name.substr(0, zTree_Name.length - 1);
//            }
//        }
//    })


//console.log(zNodes);



 //function BandDepart() {

        //    $(".SelDepart").empty();

        //    $.ajax({
        //        url: "/Users/DepartmentInfoGet",
        //        type: "post",
        //        datatype: "json",
        //        success: function (res) {
        //            var list = "";

        //            $(res.Departments).each(function () {
        //                list += "<option value='" + this.DepartmentId + "'>" + this.DepartmentName + "</option>";
        //            })
        //            $(".SelDepart").append(list);
        //        }
        //    })

        //    $(".SelDepart").change(function () {
        //        BandPosition();
        //    })

        //}

        //function BandPosition() {
        //    var DerId = $(".SelDepart").val();

        //    $(".SelPosition").empty();
        //    $.ajax({
        //        url: "/Users/PositionInfoGet",
        //        type: "post",
        //        datatype: "json",
        //        data: {
        //            DerId: DerId
        //        },
        //        success: function (res) {
        //            var list = "";

        //            $(res.positions).each(function () {
        //                list += "<option value='" + this.Id + "'>" + this.PositName + "</option>";
        //            })
        //            $(".SelPosition").append(list);
        //        }
        //    })
        //    $(".SelPosition").change(function () {
        //        BandStaff();
        //    })
        //}

        //function BandStaff() {
        //    var posId = $(".SelPosition").val();

        //    $(".SelStaff").empty();

        //    $.ajax({
        //        url: "/Users/StaffInfoGet",
        //        type: "post",
        //        datatype: "json",
        //        data: {
        //            posId: posId
        //        },
        //        success: function (res) {
        //            var list = "";

        //            $(res.staffs).each(function () {
        //                list += "<option value='" + this.Id + "'>" + this.StaffName + "</option>";
        //            })
        //            $(".SelStaff").append(list);
        //        }
        //    })
        //}


var zNodes = [
    { id: 1, pId: 0, name: "产品部", open: true },
    { id: 2, pId: 0, name: "技术部", open: true },
    { id: 3, pId: 0, name: "市场部" },
    { id: 4, pId: 0, name: "后勤部" },
    { id: 5, pId: 0, name: "人事部" },
    { id: 6, pId: 0, name: "财务部" },
    { id: 11, pId: 1, name: "产品经理" },
    { id: 12, pId: 1, name: "产品推销" },
    { id: 13, pId: 1, name: "职员" },
    { id: 21, pId: 2, name: "技术经理" },
    { id: 22, pId: 2, name: "技术员" },
    { id: 23, pId: 2, name: "职员" },
    { id: 31, pId: 3, name: "市场经理" },
    { id: 32, pId: 3, name: "市场推销" },
    { id: 33, pId: 3, name: "职员" },
    { id: 41, pId: 4, name: "后勤管理" },
    { id: 42, pId: 4, name: "职员" },
    { id: 51, pId: 5, name: "人事助理" },
    { id: 52, pId: 5, name: "职员" },
    { id: 61, pId: 6, name: "财务管理" },
    { id: 62, pId: 6, name: "会计" },
    { id: 111, pId: 11, name: "松岛枫" },
    { id: 112, pId: 12, name: "阿斯蒂芬" },
    { id: 113, pId: 13, name: "刘海中" },
    { id: 121, pId: 21, name: "颜人中" },
    { id: 122, pId: 22, name: "刘亦菲" },
    { id: 123, pId: 23, name: "刘德华" },
    { id: 131, pId: 31, name: "井上岗次" },
    { id: 132, pId: 32, name: "罗非花" },
    { id: 133, pId: 33, name: "焦若云" },
    { id: 141, pId: 41, name: "士大夫" },
    { id: 142, pId: 42, name: "德比" },
    { id: 143, pId: 51, name: "华纳怒" },
    { id: 151, pId: 52, name: "故洛出" },
    { id: 152, pId: 61, name: "星星器" },
    { id: 153, pId: 62, name: "哼哼" },
    { id: 161, pId: 11, name: "吴一峰" },
    { id: 162, pId: 12, name: "张三" },
    { id: 163, pId: 21, name: "李四" },
    { id: 171, pId: 22, name: "王五" },
    { id: 172, pId: 31, name: "阿萨" },
    { id: 173, pId: 32, name: "德拉" },
];

$(document).ready(function () {
    $.fn.zTree.init($("#treeDemo"), setting, zNodes);
});



function onCheck(e, treeId, treeNode) {
    var treeObj = $.fn.zTree.getZTreeObj("treeDemo"),
        nodes = treeObj.getCheckedNodes(true),
        v = "";
    for (var i = 0; i < nodes.length; i++) {
        v += nodes[i].name + ",";
        //console.log("节点id:" + nodes[i].id + "节点名称" + v); //获取选中节点的值
    }


    var stringRes = v.split(",");

    console.log(stringRes);

    var zTreeDetail = stringRes[0] + " " + stringRes[1] + " " + stringRes[2];

    $("#ProjectDetail").text(zTreeDetail);

    //$("#hidzTree1").val(zTreeDetail);


}

//技术负责人

var setting1 = {
    check: {
        //chkboxType: { "Y": "ps", "N": "ps" },
        chkStyle: "checkbox",//复选框类型
        enable: true //每个节点上是否显示 CheckBox
    },
    data: {
        simpleData: {
            enable: true
        }
    },
    callback: {
        //beforeCheck: false,
        onCheck: technologyonCheck,
        //ProductonCheck:ProductonCheck,
    }

};


$(document).ready(function () {
    $.fn.zTree.init($("#treeDemoTechnology"), setting1, zNodes);
});



function technologyonCheck(e, treeId, treeNode) {
    var treeObj = $.fn.zTree.getZTreeObj("treeDemoTechnology"),
        nodes = treeObj.getCheckedNodes(true),
        v = "";
    for (var i = 0; i < nodes.length; i++) {
        v += nodes[i].name + ",";
        //console.log("节点id:" + nodes[i].id + "节点名称" + v); //获取选中节点的值
    }


    var stringRes = v.split(",");

    console.log(stringRes);

    var zTreeDetail = stringRes[0] + " " + stringRes[1] + " " + stringRes[2];

    $("#technologyDetail").text(zTreeDetail);

}

//测试负责人

var setting3 = {
    check: {
        //chkboxType: { "Y": "ps", "N": "ps" },
        chkStyle: "checkbox",//复选框类型
        enable: true //每个节点上是否显示 CheckBox
    },
    data: {
        simpleData: {
            enable: true
        }
    },
    callback: {
        //beforeCheck: false,
        onCheck: TestonCheck,
    }

};


$(document).ready(function () {
    $.fn.zTree.init($("#treeDemoTest"), setting3, zNodes);
});



function TestonCheck(e, treeId, treeNode) {
    var treeObj = $.fn.zTree.getZTreeObj("treeDemoTest"),
        nodes = treeObj.getCheckedNodes(true),
        v = "";
    for (var i = 0; i < nodes.length; i++) {
        v += nodes[i].name + ",";
        //console.log("节点id:" + nodes[i].id + "节点名称" + v); //获取选中节点的值
    }


    var stringRes = v.split(",");

    console.log(stringRes);

    var zTreeDetail = stringRes[0] + " " + stringRes[1] + " " + stringRes[2];

    $("#TestDetail").text(zTreeDetail);

}

//产品负责人

var setting2 = {
    check: {
        //chkboxType: { "Y": "ps", "N": "ps" },
        chkStyle: "checkbox",//复选框类型
        enable: true //每个节点上是否显示 CheckBox
    },
    data: {
        simpleData: {
            enable: true
        }
    },
    callback: {
        //beforeCheck: false,
        onCheck: ProductonCheck,
    }

};


$(document).ready(function () {
    $.fn.zTree.init($("#treeDemoProduct"), setting2, zNodes);
});



function ProductonCheck(e, treeId, treeNode) {
    var treeObj = $.fn.zTree.getZTreeObj("treeDemoProduct"),
        nodes = treeObj.getCheckedNodes(true),
        v = "";
    for (var i = 0; i < nodes.length; i++) {
        v += nodes[i].name + ",";
        //console.log("节点id:" + nodes[i].id + "节点名称" + v); //获取选中节点的值
    }


    var stringRes = v.split(",");

    console.log(stringRes);

    var zTreeDetail = stringRes[0] + " " + stringRes[1] + " " + stringRes[2];

    $("#ProductDetail").text(zTreeDetail);

}


//市场

var setting4 = {
    check: {
        //chkboxType: { "Y": "ps", "N": "ps" },
        chkStyle: "checkbox",//复选框类型
        enable: true //每个节点上是否显示 CheckBox
    },
    data: {
        simpleData: {
            enable: true
        }
    },
    callback: {
        //beforeCheck: false,
        onCheck: MarkonCheck,
    }

};


$(document).ready(function () {
    $.fn.zTree.init($("#treeDemoMark"), setting4, zNodes);
});



function MarkonCheck(e, treeId, treeNode) {
    var treeObj = $.fn.zTree.getZTreeObj("treeDemoMark"),
        nodes = treeObj.getCheckedNodes(true),
        v = "";
    for (var i = 0; i < nodes.length; i++) {
        v += nodes[i].name + ",";
        //console.log("节点id:" + nodes[i].id + "节点名称" + v); //获取选中节点的值
    }


    var stringRes = v.split(",");

    console.log(stringRes);

    var zTreeDetail = stringRes[0] + " " + stringRes[1] + " " + stringRes[2];

    $("#MarkDetail").text(zTreeDetail);

}