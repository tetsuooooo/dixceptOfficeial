<template>
    <section>
        <div class="bg_color_black main_img_div">
            <v-img :src="require('../assets/home.jpg')" width="100%" aspect-ratio="1.4" class="main_img" contain></v-img>
        </div>
        <home-ranking></home-ranking>
        <home-news></home-news>
        <home-player></home-player>
        <home-social></home-social>
        <home-next-match></home-next-match>
        <home-partners></home-partners>
    </section>

</template>

<script lang="ts">
    import { Component, Vue } from 'vue-property-decorator';
    import HomeRanking from '../components/HomeRanking.vue';
    import HomeNews from '../components/HomeNews.vue';
    import HomePlayer from '../components/HomePlayer.vue';
    import HomeSocial from '../components/HomeSocial.vue';
    import HomeNextMatch from '../components/HomeNextMatch.vue';
    import HomePartners from '../components/HomePartners.vue';

    @Component({
        components: {
            HomeRanking,
            HomeNews,
            HomePlayer,
            HomeSocial,
            HomeNextMatch,
            HomePartners
        },
    })
    export default class Home extends Vue {

    }
</script>

<style scoped>
    .main_img_div{
        height: 700px;
        padding-bottom: 2%;
    }
    .main_img{
        height: 100%;
    }
    @media screen and (max-width:480px) {
        .main_img_div{
        height: 350px;
    }
    }
</style>
