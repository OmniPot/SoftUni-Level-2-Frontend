var students = 
[{"gender":"Male","firstName":"Joe","lastName":"Riley","age":22,"country":"Russia"},
{"gender":"Female","firstName":"Lois","lastName":"Morgan","age":41,"country":"Bulgaria"},
{"gender":"Male","firstName":"Roy","lastName":"Wood","age":33,"country":"Russia"},
{"gender":"Female","firstName":"Diana","lastName":"Freeman","age":40,"country":"Argentina"},
{"gender":"Female","firstName":"Bonnie","lastName":"Hunter","age":23,"country":"Bulgaria"},
{"gender":"Male","firstName":"Joe","lastName":"Young","age":16,"country":"Bulgaria"},
{"gender":"Female","firstName":"Kathryn","lastName":"Murray","age":22,"country":"Indonesia"},
{"gender":"Male","firstName":"Dennis","lastName":"Woods","age":37,"country":"Bulgaria"},
{"gender":"Male","firstName":"Billy","lastName":"Patterson","age":24,"country":"Bulgaria"},
{"gender":"Male","firstName":"Willie","lastName":"Gray","age":42,"country":"China"},
{"gender":"Male","firstName":"Justin","lastName":"Lawson","age":38,"country":"Bulgaria"},
{"gender":"Male","firstName":"Ryan","lastName":"Foster","age":24,"country":"Indonesia"},
{"gender":"Male","firstName":"Eugene","lastName":"Morris","age":37,"country":"Bulgaria"},
{"gender":"Male","firstName":"Eugene","lastName":"Rivera","age":45,"country":"Philippines"},
{"gender":"Female","firstName":"Kathleen","lastName":"Hunter","age":28,"country":"Bulgaria"}]

var ageRestrictedStudentsList = _.filter(students, function (student) {
	return student.age <= 24 && student.age >= 18;
})
console.log("Students between 18 and 24.");
console.log(ageRestrictedStudentsList);

var alphabeticallyByName = _.filter(students, function (s) {
	return s.firstName.localeCompare(s.lastName) == -1;
})
console.log("Students whose first name is before their last name.");
console.log(alphabeticallyByName);

// var countryFilter = _.map((_.filter(students, function (s) {
// 	return s.country == "Bulgaria";
// })), fullName);

var countryFilter = _.map(
    _.where(students, {country : "Bulgaria"}), 
    function(student) {
        return student.firstName + ' ' + student.lastName;
    }
);
console.log("Bulgarian students' names.");
console.log(countryFilter);

var lastFiveStudents = _.takeRight(students, 5);
console.log("Last five students.");
console.log(lastFiveStudents);

var firstThreeForeignMale = _.slice(_.filter(students, function (s) {
	return s.country != "Bulgaria" && s.gender == "Male";
}), 0 , 3);
console.log("First three male foreigners.");
console.log(firstThreeForeignMale);