<template>
    <v-app>
        <v-main>
            <v-container fluid>
                <Header></Header>
                <transition name="fade" mode="out-in">
                    <router-view></router-view>
                </transition>
                <Footer></Footer>
            </v-container>
        </v-main>
    </v-app>
</template>

<script lang="ts">
    import Vue from 'vue';
    import Header from './components/Header.vue'
    import Footer from './components/Footer.vue'
    
    export default Vue.extend({
        name: 'App',
        components: {
            Header,
            Footer
        },
        data: () => ({

        }),
    });
</script>

<style>
    /* 左右の余白を削除 */
    .container {
        max-width: 100vw;
        padding: 0px;
    }
    .bg_color_black {
        background-color: black !important;
    }
    /* 選手紹介css scopedを使用すると[data-nnn]つけられて適用されなくなるのであえてグローバルに書く */
    .player_bg {
        height: 500px;
        background-image: url("./assets/player_bg.jpg");
        background-repeat: no-repeat;
        background-size: cover;
        background-position: center;
    }

    .player_slick .slick-slide:not(.slick-center) {
        -webkit-filter: grayscale(100%);
        -moz-filter: grayscale(100%);
        -o-filter: grayscale(100%);
        -ms-filter: grayscale(100%);
        filter: grayscale(100%);
        transition: 0.2s linear;
    }

    /* 試合カルーセルcss */
    .match_team_area {
        height: 150px;
    }

    .match_area {
        height: 300px;
    }

    .match_margin {
        margin-top: 40%;
    }

    .match_border {
        border-top: 1px solid white;
        border-bottom: 1px solid white;
    }

    .match_point_margin {
        margin-top: 25%
    }

    .match_border_bottom {
        border-bottom: 1px solid white;
    }

    .bg_color {
        background-color: black !important;
    }

    .bg_color_green {
        background-color: #026B2F;
    }

    .padding_none {
        padding: 0px !important;
    }

    .fade-enter, .fade-leave-to {
        opacity: 0;
    }

    .fade-enter-active, .fade-leave-active {
        transition: opacity 0,7;
    }

     @media screen and (max-width:480px){
        .sp_padding_none{
            padding: 0px !important;
        }
        .player_bg {
        height: 300px;
        }
        .sp_player_div{
        width: 100%;
        height: 300px;
        margin: auto;
        }
        .sp_player_img{
            width: 60% !important;
            margin: auto;
        }
        .sp_player_font_sm{
            font-size: 25px !important;
        }
        .row_margin{
            margin: 0px !important;
        }
    }
  
</style>
