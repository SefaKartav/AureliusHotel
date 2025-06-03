<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="otel.aspx.cs" Inherits="otel.otel" %>

<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <link rel="stylesheet" href="styles.css">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.5.0/css/all.min.css">
</head>
<body>
    <header class="header">
        <div class="logo-container">
            <img src="img/logo.png" alt="Aurelius Hotel Logosu" />
            <span class="toggle-btn">☰</span>
        </div>
        <ul class="nav-right display-none-mobile">
            <li><a href="HAKKIMIZDA/anasayfa.aspx">Hakkımızda</a></li>
            <li><asp:HyperLink ID="HyperLinkLogin" runat="server" Text="Giriş Yap" NavigateUrl="/WebForm2.aspx"></asp:HyperLink></li>
            <li><a href="/WebForm1.aspx">Rezervasyon</a></li>
        </ul>
    </header>

    <header class="main-header">
        <div class="content">
            <h1> Aurelius Hotel</h1>
            <p class="subtitle">Aurelius’ta Her Gün Doğaya Açılan Bir Sayfa</p>
        </div>
    </header>
    <section>
        <div class="icon-container">
            <div>
                <i class="fa-solid fa-bell-concierge"></i>
                <h3>Oda Servisi</h3>
            </div>
            <div>
                <i class="fa-solid fa-utensils"></i>
                <h3>Restoran Servisi</h3>
            </div>
            <div>
                <i class="fa-solid fa-spa"></i>
                <h3>Spa Servisi</h3>
            </div>
        </div>
    </section>
    <section>
        <div class="icon-container">
            <div>
                <i class="fa-solid fa-bus-simple"></i>
                <h3>Ulaşım Servisi</h3>
            </div>
            <div>
                <i class="fa-solid fa-mug-saucer"></i>
                <h3>Kahve Servisi</h3>
            </div>
            <div>
                <i class="fa fa-bed" aria-hidden="true"></i>
                <h3>Yatak Servisi</h3>
            </div>
        </div>
    </section>
    <section>
        <div>
            <p class="gallery-title">Otelimizdeki Yerler</p>
        </div>
        <div class="flex-container">
            <div class="image-card">
                <img src="img/foto1.jpg" alt="Otel Bahçesi">
                <div class="description">
                    <h3>Otel Bahçesi</h3>
                    <p>Doğayla iç içe huzurlu bir bahçe alanı.</p>
                </div>
            </div>
            <div class="image-card">
                <img src="/web-otel/HAKKIMIZDA/img2/lobi.jpg" alt="Lobi">
                <div class="description">
                    <h3>Lobi</h3>
                    <p>Modern ve konforlu karşılama alanı.</p>
                </div>
            </div>
            <div class="image-card">
                <img src="/web-otel/HAKKIMIZDA/img2/fitness4.jpg" alt="Havuz">
                <div class="description">
                    <h3>Havuz</h3>
                    <p>Yaz aylarında serinlemek için ideal.</p>
                </div>
            </div>
            <div class="image-card">
                <img src="/web-otel/HAKKIMIZDA/img2/restoran.jpg" alt="Restoran">
                <div class="description">
                    <h3>Restoran</h3>
                    <p>Lezzetli yemeklerin tadını çıkarın.</p>
                </div>
            </div>
            <div class="image-card">
                <img src="/web-otel/HAKKIMIZDA/img2/spa.jpg" alt="Spa Merkezi">
                <div class="description">
                    <h3>Spa Merkezi</h3>
                    <p>Rahatlatıcı bir spa deneyimi.</p>
                </div>
            </div>
            <div class="image-card">
                <img src="/web-otel/HAKKIMIZDA/img2/konferans.jpg" alt="Konferans Salonu">
                <div class="description">
                    <h3>Konferans Salonu</h3>
                    <p>İş toplantıları için modern bir alan.</p>
                </div>
            </div>
            <div class="image-card">
                <img src="img/foto7.jpg" alt="Oda Manzarası">
                <div class="description">
                    <h3>Oda Manzarası</h3>
                    <p>Doğa manzaralı konforlu odalar.</p>
                </div>
            </div>
            <div class="image-card">
                <img src="/web-otel/HAKKIMIZDA/img2/fitness2.jpg" alt="Fitness Salonu">
                <div class="description">
                    <h3>Fitness Salonu</h3>
                    <p>Formunuzu korumak için donanımlı salon.</p>
                </div>
            </div>
        </div>
    </section>

    <section class="person-section">
        <div class="card-title">
            <h2>Personellerimizin Fotoğrafları</h2>
            <br >
            <br >
        </div>
        <div class="card-container">
            <div class="card2">
                <img src="img/eren.jpg" />
                <p>Eren Aydın</p>
            </div>
            <div class="card2">
                <img src="img/berkay.jpg" />
                <p>Berkay Enes Fidan</p>
            </div>
            <div class="card2">
                <img src="img/sefa.jpg" />
                <p>Sefa Kartav</p>
            </div>
            <div class="card2">
                <img src="img/emirhan.jpg" />
                <p>Emirhan Öztürk</p>
            </div>
        </div>
    </section>

    <footer>
        <div class="flex-container4">
            <div class="logo">
                <i class="fas fa-hotel"></i>
                <span>Aurelius </span> Hotel
            </div>
        </div>
        <p class="footer-copy">BEF © 2025 - Aurelius Hotel Site</p>
    </footer>

    <script src="javas.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/gsap/3.12.5/gsap.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/gsap/3.12.5/ScrollTrigger.min.js"></script>
</body>

</html>