// ── Mobile Nav Toggle (shared across all pages) ──
(function(){
  var btn     = document.getElementById('mobileMenuBtn');
  var nav     = document.getElementById('mobileNav');
  var overlay = document.getElementById('mobileOverlay');

  function closeNav(){
    nav.classList.remove('open');
    overlay.classList.remove('show');
    btn.innerHTML = '<i class="fa-solid fa-bars"></i>';
  }
  function openNav(){
    nav.classList.add('open');
    overlay.classList.add('show');
    btn.innerHTML = '<i class="fa-solid fa-xmark"></i>';
  }

  btn.addEventListener('click', function(){
    nav.classList.contains('open') ? closeNav() : openNav();
  });
  overlay.addEventListener('click', closeNav);
  nav.querySelectorAll('.nav-item').forEach(function(l){
    l.addEventListener('click', closeNav);
  });
})();
