//$('.pickadate').pickadate();
$('.pickatime').pickatime({
    disable: [
    [0, 00],
    [0, 30],
    [1, 0],
    [1, 30],
    [2, 0],
    [2, 30],
    [3, 0],
    [3, 30],
    [4, 00]
    [4, 30],
    [5, 0],
    [5, 30],
    [6, 0],
    [6, 30],
    [7, 0],
    [7, 30],
    [8, 0],
    [8, 30],
    [9, 00]
    [9, 30],
    [10, 0],
    [10, 30],
    [11, 0],
    [11, 30],
    [13, 0],
    [15, 30],
    ],

});
$('.pickadate').pickadate({
    disable: [
        new Date(2023, 6, 25),
        new Date(2023, 6, 26),
        { from: [0, 0, 0], to: true },
        1,4,7
    ],
});




window.addEventListener('load', function () {
    const label = document.querySelector('#welcome');
    fetch('/api/values/GetName', {
        headers: {
            'Content-Type': 'application/json'
        }
    })
        .then(response => response.text())
        .then(text => {
            // Remove quotation marks using regex replace
            const cleanedText = text.replace(/"/g, '');
            label.textContent = "Welcome " + cleanedText;
        })
        .catch(error => {
            console.error(error);
        });
});

var appointmentBtn = document.getElementById('appointment-btn');

// Add a click event listener to the button
appointmentBtn.addEventListener('click', function () {
    // Display a message
    alert('Your appointment has been booked!');

    // Redirect to the main page
    window.location.href = 'Appointment.html';
});

