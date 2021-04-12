<template>
    <v-row>
        <v-divider></v-divider>
        <v-col cols="12" class="text-h2 text-center">Player</v-col>
        <v-col cols="12">
            <slick ref="slick" :options="slickOptions" class="player_slick player_bg">
                <v-col v-for="(n, index) in 10" :key="index" class="image-thumb">
                    <v-img src="../assets/dixsept_header_logo.png"></v-img>
                </v-col>
            </slick>
            <slick ref="slick" :options="slickNavOptions" class="player_nav_area">
                <v-row v-for="(n, index) in 10" :key="index" align="center" justify="center" class="bg_color">
                    <v-col>
                        <v-row align="center" justify="center">
                            <v-col cols="6" sm="1" class="white--text text-center text-h2">10</v-col>
                            <v-col cols="6" sm="1" class="white--text text-left text-h5">Fixo</v-col>
                            <v-col cols="12" sm="8" class="white--text text-center text-h2">SAMPLE TARO</v-col>
                            <v-col cols="12" sm="2">
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
</style>

