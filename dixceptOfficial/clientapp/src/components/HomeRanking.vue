<template>
    <div>
        <v-row class="bg_color_black">
            <v-col cols="12" class="home_ranking_bg">
                <v-row justify="space-around" align-content="center" class="ranking_height">
                    <v-col cols="6" class="text-center">
                        <v-col cols="12" class="text-center">
                            <label class="white--text text-h5 font-weight-bold">埼玉県フットサル2部リーグ 2021～2022</label>
                        </v-col>
                        <v-col cols="12" class="text-center">
                            <label class="white--text text-h5-1 font-weight-bold" to="/">More</label>
                        </v-col>
                    </v-col>
                    <v-col cols="6" class="text-center">
                        <label class="white--text number_font">
                            <span class="white--text text-h5">現在</span>
                            1
                            <span class="white--text text-h5">位</span>
                        </label>
                    </v-col>
                </v-row>
            </v-col>
            <v-col cols="12" class="match_area">
                    <slick ref="slick" :options="slickOptions">
                        <v-col cols="11" v-for="(value, index) in 5" :key="index">
                            <v-row>
                                <v-col cols="12" class="white--text subtitle-2 text-center text-h5">埼玉県フットサル2部リーグ</v-col>
                            </v-row>
                            <v-row align-content="center" class="match_team_area match_border">
                                <v-col cols="5">
                                    <v-row justify="center" align-content="center">
                                        <v-col cols="7">
                                            <v-row justify="center" align-content="center">
                                                <v-col cols="12">
                                                    <v-img :src="require(`../assets/dixsept_header_logo.png`)" height="100" class="ma-auto padding_none"></v-img>
                                                </v-col>
                                                <v-col cols="12" class="white--text subtitle-2 text-center padding_none">
                                                    dixcept浦和FC
                                                </v-col>
                                            </v-row>
                                        </v-col>
                                        <v-col cols="5">
                                            <v-col cols="12" class="white--text text-h2 text-center match_point_margin">0</v-col>
                                        </v-col>
                                    </v-row>
                                </v-col>
                                <v-col cols="2">
                                    <v-col class="white--text text-h5 text-center match_margin">VS</v-col>
                                </v-col>
                                <v-col cols="5">
                                    <v-row justify="center" align-content="center">
                                        <v-col cols="5">
                                            <v-col cols="12" class="white--text text-h2 text-center match_point_margin">0</v-col>
                                        </v-col>
                                        <v-col cols="7">
                                            <v-row justify="center" align-content="center">
                                                <v-col cols="12">
                                                    <v-img :src="require(`../assets/other.png`)" height="100" class="ma-auto padding_none"></v-img>
                                                </v-col>
                                                <v-col cols="12" class="white--text subtitle-2 text-center padding_none">
                                                    相手チーム
                                                </v-col>
                                            </v-row>
                                        </v-col>
                                    </v-row>
                                </v-col>
                            </v-row>
                            <v-row align-content="center" class="match_border_bottom">
                                <v-col cols="6" class="white--text subtitle-1 text-center">2021/04/{{index}} 12:00 KICKOFF</v-col>
                                <v-col cols="6" class="white--text subtitle-1 text-center">富士見総合体育館</v-col>
                            </v-row>
                        </v-col>
                    </slick>
            </v-col>
        </v-row>
    </div>
</template>

<script lang="ts">
    import { Component, Vue } from 'vue-property-decorator';
    import Slick from 'vue-slick';
    import '../../node_modules/slick-carousel/slick/slick.css';

    @Component({
        components: {
            Slick
        },
    })
    export default class Home extends Vue {
        data() {
            return {
                // Slickの設定
                slickOptions: {
                    autoplay: true,
                    dots: false,
                    infinite: true,
                    speed: 600,
                    slidesToShow: 2,
                    centerMode: true,
                    centerPadding: '5%',
                    accessibility: false,
                    arrows: false,
                }
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
    .bg_color_black {
        background-color: black !important;
    }
    .home_ranking_bg {
        background-image: url("../assets/rank_bg.png");
        background-repeat: no-repeat;
        background-size: cover;
        background-position: center;
    }

    .ranking_height {
        height: 300px;
    }

    .number_font {
        font-size: 100px;
        font-weight: bold;
    }

</style>
