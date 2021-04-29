<template>
    <div class="bg_color_black">
            <v-container fluid class="home_ranking_bg">
                <v-row justify="space-around" align-content="center" class="ranking_height sp_row_margin">
                    <v-col cols="12" sm="6" class="text-center sp_padding_none">
                        <label class="white--text text-h5 font-weight-bold hidden-sm-and-down text-center">埼玉県フットサル2部リーグ 2021～2022</label>
                        <label class="white--text text-h5 font-weight-bold hidden-sm-and-up text-center">埼玉県フットサル2部リーグ<br>2021～2022</label>
                        <v-col cols="12" sm="12" class="text-center sp_padding_none">
                            <label class="white--text text-h5-1 font-weight-bold" to="/">More</label>
                        </v-col>
                    </v-col>
                    <v-col cols="12" sm="6" class="text-center sp_padding_none">
                        <label class="white--text number_font text-center">1</label>
                        <span class="white--text text-h5 text-right">位</span>
                    </v-col>
                </v-row>
            </v-container>
            <div class="match_area mt-5">
                    <slick ref="slick" :options="slickOptions">
                        <v-col cols="12" sm="11" v-for="(value, index) in 5" :key="index">
                            <v-row>
                                <v-col cols="12" class="white--text text-center text-h5">埼玉県フットサル2部リーグ</v-col>
                            </v-row>
                            <!-- 2段目 -->
                            <v-row align-content="center" class="match_team_area match_border">
                                <!-- ホーム -->
                                <v-col cols="5" class="sp_padding_none">
                                    <v-row justify="center" align-content="center">
                                        <v-col cols="9" sm="7">
                                            <v-row justify="center" align-content="center">
                                                <v-col cols="12">
                                                    <v-img :src="require(`../assets/dixsept_header_logo.png`)" height="100" class="ma-auto padding_none sp_rank_img"></v-img>
                                                </v-col>
                                                <v-col cols="12" class="white--text subtitle-2 text-center padding_none">
                                                    dixcept浦和FC
                                                </v-col>
                                            </v-row>
                                        </v-col>
                                        <v-col cols="3" sm="5" class="white--text text-h2 text-center match_point_margin sp_padding_none">0</v-col>
                                    </v-row>
                                </v-col>
                                <v-col cols="2" class="white--text text-h5 text-center ma-auto">VS</v-col>
                                <!-- 相手 -->
                                <v-col cols="5" class="sp_padding_none">
                                    <v-row justify="center" align-content="center">
                                        <v-col cols="3" sm="5" class="white--text text-h2 text-center match_point_margin sp_padding_none">0</v-col>
                                        <v-col cols="9" sm="7">
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
                            <!-- 3段目 -->
                            <v-row align-content="center" class="match_border_bottom">
                                <v-col cols="12" sm="6" class="white--text subtitle-1 text-center">2021/04/{{index}} 12:00 KICKOFF</v-col>
                                <v-col cols="6" class="white--text subtitle-1 text-center hidden-sm-and-down">富士見総合体育館</v-col>
                            </v-row>
                            <!-- sp画面のみ表示 -->
                            <v-row align-content="center" class="match_border_bottom hidden-sm-and-up">
                                <v-col cols="12" class="white--text subtitle-1 text-center">富士見総合体育館</v-col>
                            </v-row>
                        </v-col>
                    </slick>
            </div>
        
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
                    responsive:[
                        {
                            breakpoint: 480,
                            settings:{
                                slidesToShow: 1,
                                 centerMode: true,
                                  centerPadding: '0px',
                            }
                        },
                    ]
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
        width: 100%;
    }
    .home_ranking_bg {
        background-image: url("../assets/rank_bg.png");
        background-repeat: no-repeat;
        background-size: cover;
        background-position: center;
    }

    .ranking_height {
        height: 300px;
        width: 100%;
    }

    .number_font {
        font-size: 100px;
        font-weight: bold;
    }
    .match_point_margin{
            margin: auto;
    }

    @media screen and (max-width:480px){
        .sp_padding_none{
            padding: 0px !important;
        }
        .ranking_height {
            height: 250px;
        }
        /* 対戦表画像設定 */
        .sp_rank_img{
            width: 100%;
        }
        /* 対戦表得点フォント */
        .match_point_font{
            font-size: 18px !important;
        }
        .sp_row_margin{
            margin: 0px !important;
        }
        .match_area{
            height: 330px;
        }
        
        
    }

</style>
