<template>
    <v-row>
        <v-divider></v-divider>
        <v-col cols="12" class="text-h2 text-center">Player</v-col>
        <v-col cols="12">
            <slick ref="slick" :options="slickOptions" class="player_slick player_bg">
                <v-col v-for="(n, index) in 10" :key="index" class="image-thumb sp_player_div text-center">
                    <v-img src="../assets/dixsept_header_logo.png" class="sp_player_img"></v-img>
                </v-col>
            </slick>
            <slick ref="slick" :options="slickNavOptions" class="player_nav_area">
                <v-row v-for="(n, index) in 10" :key="index" align="center" justify="center" class="bg_color row_margin">
                    <v-col>
                        <v-row align="center" justify="center">
                            <v-col cols="6" sm="1" class="white--text text-sm-center text-right text-sm-h2 text-h5">10</v-col>
                            <v-col cols="6" sm="1" class="sp_player_font_sm white--text text-left text-h5">Fixo</v-col>
                            <v-col cols="12" sm="8" class="white--text text-center text-sm-h2 text-h4">SAMPLE TARO</v-col>
                            <v-col cols="12" sm="2" class="text-center text-sm-right mb-1">
                                <v-btn color="green darken-4">View More</v-btn>
                            </v-col>
                        </v-row>
                    </v-col>
                </v-row>
            </slick>
        </v-col>
    </v-row>
</template>

<script lang="ts">
    import { Component, Vue } from 'vue-property-decorator';
    import Slick from 'vue-slick';
    import '../../node_modules/slick-carousel/slick/slick.css'

    @Component({
        components: {
            Slick,
        },
    })
    export default class Home extends Vue {
        data() {
            return {
                // slickの設定
                slickOptions: {
                    autoplay: true,
                    dots: false,
                    infinite: true,
                    speed: 300,
                    slidesToShow: 3,
                    centerMode: true,
                    centerPadding: '60px',
                    accessibility: false,
                    arrows: false,
                    asNavFor: '.player_nav_area',
                    responsive:[
                        {
                            breakpoint: 480,
                            settings:{
                                slidesToShow: 1,
                                centerMode: true,
                                centerPadding: '0%',
                            }
                        },
                    ]
                },
                slickNavOptions: {
                    asNavFor: '.player_slick',
                    focusOnSelect: false,
                    arrows: false,
                    slidesToShow: 1,
                },
            }
        }
        next() {
            var refs: any = this.$refs
            refs.slick.next();
        }
        prev() {
            var refs: any = this.$refs
            refs.slick.prev();
        }
        reInit() {
            this.$nextTick(() => {
                var refs: any = this.$refs
                refs.slick.reSlick();
            });
        }

    }
</script>

<style scoped>
@media screen and (max-width: 480px){
    
}
</style>

