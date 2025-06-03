window.addEventListener('load', function(){
  document.getElementsByTagName('header')[0].addEventListener('click', function(){
    toggle_menu();
  });
});

window.addEventListener('scroll', function(){
  header_scroll();
  parallax('main-header', 5, 0);
});

window.addEventListener('DOMContentLoaded', function() {
  if (window.gsap && window.ScrollTrigger) {
    gsap.registerPlugin(ScrollTrigger);

    // Ana başlık animasyonları
    gsap.to(".main-header .content h1", {
      y: -100,
      opacity: 0,
      duration: 1,
      scrollTrigger: {
        trigger: ".main-header",
        start: "top top",
        end: "bottom top",
        scrub: true
      }
    });

    gsap.to(".main-header .content .subtitle", {
      y: 100,
      opacity: 0,
      duration: 1,
      scrollTrigger: {
        trigger: ".main-header",
        start: "top top",
        end: "bottom top",
        scrub: true
      }
    });

    // Mevcut diğer öğeler için animasyon
      gsap.utils.toArray('.icon-container div, .image-card, .gallery-title, .subtitle2, .card, .card2').forEach(function(elem) {
      gsap.fromTo(elem,
        { y: 60, opacity: 0 },
        {
          y: 0,
          opacity: 1,
          duration: 1,
          scrollTrigger: {
            trigger: elem,
            start: "top 80%",
            end: "top 40%",
            scrub: true
          }
        }
      );
    });

    // Yeni .image-card animasyonları
    gsap.utils.toArray('.image-card').forEach(function(card, index) {
      gsap.fromTo(card,
        { y: 60, opacity: 0 },
        {
          y: 0,
          opacity: 1,
          duration: 1,
          delay: index * 0.2, // Sırayla görünüm için gecikme
          ease: "power2.out", // Yumuşak geçiş
          scrollTrigger: {
            trigger: card,
            start: "top 80%", // Kart viewport'un %80'ine geldiğinde başlar
            end: "top 40%",
            scrub: true
            // markers: true // Hata ayıklama için (kaldırılabilir)
          }
        }
      );
    });
  }
});

function header_scroll(){
  var my_header = document.getElementsByTagName('header')[0];
  var scroll_height = window.pageYOffset;
  if(scroll_height > 50){
    my_header.className = 'header header-scroll';
  }
  else {
    my_header.className = 'header';
  }
}

function parallax(elem, speed, number){
  var target = document.getElementsByClassName(elem)[number];
  var scroll_value = window.pageYOffset;
  if(scroll_value <= 50){
    target.style.transform = 'translateY('+(-scroll_value/speed)+'px)';
  } 
  else {
    return;
  }
}

function toggle_menu(){
  var menu_bar = document.querySelector('.header ul');
  var btn = document.getElementsByClassName('toggle-btn')[0];
  if(document.documentElement.clientWidth <= 768){
    if(menu_bar.className == 'display-none-mobile'){
      menu_bar.className = 'display-block';
      menu_bar.style.animation = 'flip 1 0.4s 0s';
      btn.innerHTML = '×';
      btn.style.fontSize = '40px';
      btn.style.animation = 'fade 1 0.2s 0s';
    }
    else if(menu_bar.className == 'display-block'){
      menu_bar.className = 'display-none-mobile';
      btn.innerHTML = '☰';
      btn.style.fontSize = '30px';
      btn.style.animation = 'top-in-basic 1 0.2s 0s';
    }
  }
}