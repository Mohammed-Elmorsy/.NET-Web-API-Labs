function addStudent() {

    let fullName = document.getElementById("fullName").value;
    let address = document.getElementById("address").value;
    let studentObject = { fullName, address };

    $.ajax({
        url: 'http://localhost:65030/api/students',
        method: 'POST',
        dataType: "json",
        contentType: "application/json",
        data: JSON.stringify(studentObject),
        success: function (student) {
            $("#myTable").append(`<tr><td>${student.id}</td>
                                                   <td>${student.fullName}</td>
                                                   <td>${student.address}</td>

                                                    </tr>`)
        },
        error: function () {
            alert('error');
        }
    })
}
//load
$(function () {

    $.ajax({
        url: 'http://localhost:65030/api/students',
        method: 'GET',
        success: function (students) {
            for (student of students) {
                $("#myTable").append(`<tr><td>${student.id}</td>
                                                   <td>${student.fullName}</td>
                                                   <td>${student.address}</td>

                                                    </tr>`)
            }
        },
        error: function () {
            alert('error');
        }
    })


})