$(document).ready(function () {
  // Animations
  wow = new WOW({
    boxClass: "wow", // default
    animateClass: "animated", // default
    offset: 0, // default
    mobile: true, // default
    live: true, // default
  });
  wow.init();
  $("#datepicker").datepicker({
    uiLibrary: "bootstrap4",
  });

  $(".datepicker-container .las").click(function () {
    $(".datepicker").focus();
  });

  $(".owl-carousel").owlCarousel({
    Infinity: true,
    margin: 10,
    responsiveClass: true,
    autoplay: true,
    dots: false,
    touchDrag: true,
    mouseDrag: true,
    loop:true,
    responsive: {
      0: {
        items: 1,
        nav: true,
      },
      600: {
        items: 2,
        nav: false,
      },
      1000: {
        items: 4,
        nav: true,
        // loop: true,
      },
    },
  });

  $(window).scroll(function () {
    var scroll = $(window).scrollTop();

    if (scroll >= 10) {
      $("nav").addClass("sticky");
    } else {
      $("nav").removeClass("sticky");
    }
  });

  $("#files").change(function () {
    filename = "Select";
    console.log(filename);
  });

var step_2_form = '<div class="append_form"><input type="text" name="pet_name[]" id="pet-name" placeholder="What do you call your pet?"> <div class="choose-img-container"> <img class="choosen-img" src="assets/images/upload.png" alt="Upload a Picture" /> <input type="file" id="file" value="Select" onchange="readURL(this);" /> <label for="file" class="upload"> <i class="las la-arrow-circle-up"></i> Select</label> </div> <select id="species"> <option selected value="" disabled>Select Species</option> <option value="1">Species 1</option> <option value="2">Species 2</option> <option value="3">Species 3</option> </select> <select id="breed"> <option selected value="">Select Breed</option> <option value="1">Breed 1</option> <option value="2">Breed 2</option> <option value="3">Breed 3</option> <option value="4">Breed 4</option> <option value="5">Breed 5</option> </select> <div class="datepicker-container"> <input placeholder="Date of Birth" type="text" id="datepicker" class="form-control datepicker"> <i class="las la-calendar"></i> </div> <div class="radio-container"> <p>Your pet is a </p>  <div class="custom-control custom-radio"> <input type="radio" class="custom-control-input" id="male" name="groupOfDefaultRadios[]"> <label class="custom-control-label" for="male">Male</label> </div>  <div class="custom-control custom-radio"> <input type="radio" class="custom-control-input" id="female" name="groupOfDefaultRadios[]" checked> <label class="custom-control-label" for="female">Female</label> </div> </div> <div class="custom-control custom-checkbox"> <input type="checkbox" class="custom-control-input" id="suggest_matching_friends" name="suggest_matching_friends[]"> <label class="custom-control-label" for="suggest_matching_friends">Suggest Matching Friends</label> </div> </div>'

  $("#add-another-pet").click(function(){
    $("#append_form").append(step_2_form);
  });

  $('.tilt').universalTilt();
  $('.selectpicker').selectpicker();

  // notifications 

  $(".notification-list li span").click(function(){
    alert("Notification remove function");
  })
});

function readURL(input) {
  if (input.files && input.files[0]) {
    var reader = new FileReader();

    reader.onload = function (e) {
      $(".choosen-img").attr("src", e.target.result).addClass("selected");
    };

    reader.readAsDataURL(input.files[0]);
  }
}


(function() {
  'use strict';
  window.addEventListener('load', function() {
  // Fetch all the forms we want to apply custom Bootstrap validation styles to
  var forms = document.getElementsByClassName('needs-validation');
  // Loop over them and prevent submission
  var validation = Array.prototype.filter.call(forms, function(form) {
  form.addEventListener('submit', function(event) {
  if (form.checkValidity() === false) {
  event.preventDefault();
  event.stopPropagation();
  }
  form.classList.add('was-validated');
  }, false);
  });
  }, false);
  })();
