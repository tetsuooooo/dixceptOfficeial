<template>
    <v-app>
        <v-main>
            <v-container fluid>
            <Header></Header>
            <router-view></router-view>
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
.container{
     max-width: 100vw;
     padding:0px;
  }
  /* 選手紹介css scopedを使用すると[data-nnn]つけられて適用されなくなるのであえてグローバルに書く */
  .player_bg{
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
   .bg_color {
        background-color: black !important;
    }
    .bg_color_green{
        background-color: #026B2F;
    }
    .padding_none{
        padding: 0px !important;
    }
</style>
