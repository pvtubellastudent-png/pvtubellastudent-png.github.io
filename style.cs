
/* GENERAL DESIGN */
* {
    margin: 0;
    padding: 0;
    box-sizing: border-box;
    scroll-behavior: smooth;
}

body {
    font-family: Arial, sans-serif;
    background: #ffffff;
    color: #344256;
    line-height: 1.6;
}

/* NAVIGATION */
header {
    background: #ffffff;
    padding: 20px 8%;
    border-bottom: 1px solid #eeeeee;
}

nav {
    display: flex;
    justify-content: space-between;
    align-items: center;
}

nav h2 {
    color: #172b4d;
}

nav ul {
    display: flex;
    gap: 25px;
    list-style: none;
}

nav ul a {
    text-decoration: none;
    color: #344256;
    font-weight: bold;
}

nav ul a:hover {
    color: #3568c8;
}

/* HOME */
.home {
    min-height: 550px;
    padding: 70px 10%;
    display: flex;
    align-items: center;
    justify-content: center;
    gap: 70px;
    background: #f5f8fd;
}

.home-text {
    max-width: 500px;
}

.home-text > p:first-child {
    color: #3568c8;
    font-weight: bold;
    font-size: 13px;
    letter-spacing: 1px;
}

.home-text h1 {
    font-size: 42px;
    color: #172b4d;
    margin: 15px 0;
}

.home-text h1 span {
    color: #3568c8;
}

.home-text h2 {
    font-size: 21px;
    margin-bottom: 15px;
}

.home-text p {
    margin-bottom: 20px;
}

.btn {
    display: inline-block;
    background: #3568c8;
    color: white;
    padding: 11px 23px;
    border-radius: 6px;
    text-decoration: none;
}

.btn:hover {
    background: #172b4d;
}

/* PROFILE PHOTO */
.photo {
    width: 280px;
    height: 340px;
    border-radius: 12px;
    overflow: hidden;
    border: 5px solid white;
    box-shadow: 0 8px 25px rgba(0,0,0,0.10);
}

.photo img {
    width: 100%;
    height: 100%;
    object-fit: cover;
    object-position: center top;
}

/* ALL SECTIONS */
section:not(.home) {
    padding: 70px 10%;
}

section:not(.home) > h1 {
    text-align: center;
    color: #172b4d;
    font-size: 32px;
    margin-bottom: 35px;
}

.light {
    background: #f5f8fd;
}

/* ABOUT AND GOALS */
.about-box {
    max-width: 750px;
    margin: auto;
    padding: 30px;
    background: white;
    border: 1px solid #e7edf5;
    border-radius: 10px;
    box-shadow: 0 5px 20px rgba(0,0,0,0.04);
}

.about-box p {
    margin-bottom: 15px;
}

/* HOBBIES AND SKILLS */
.cards {
    display: grid;
    grid-template-columns: repeat(2, 1fr);
    gap: 20px;
}

.card {
    background: white;
    padding: 25px;
    border: 1px solid #e7edf5;
    border-radius: 10px;
    transition: 0.3s;
}

.card:hover {
    transform: translateY(-5px);
    box-shadow: 0 8px 20px rgba(0,0,0,0.07);
}

.card h2 {
    color: #3568c8;
    font-size: 19px;
    margin-bottom: 10px;
}

.card p {
    color: #718096;
    font-size: 14px;
}

/* FOOTER */
footer {
    background: #172b4d;
    color: white;
    text-align: center;
    padding: 30px;
}

footer h2 {
    margin-bottom: 5px;
}

/* RESPONSIVE DESIGN */
@media (max-width: 768px) {

    nav {
        flex-direction: column;
        gap: 15px;
    }

    nav ul {
        justify-content: center;
        flex-wrap: wrap;
        gap: 12px;
    }

    .home {
        flex-direction: column-reverse;
        text-align: center;
        gap: 35px;
    }

    .home-text h1 {
        font-size: 32px;
    }

    .photo {
        width: 230px;
        height: 270px;
    }

    .cards {
        grid-template-columns: 1fr;
    }
}
