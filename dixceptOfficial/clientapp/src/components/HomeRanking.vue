<template>
    <v-row class="bg_color_black">
        <v-col cols="12" sm="5" class="home_ranking_bg" height="200">
            <v-col class="white--text text-h3 text-center">Ranking</v-col>
            <v-col class="white--text text-h5 text-center">埼玉県フットサル2部リーグ</v-col>
            <v-col class="white--text text-h1 text-center">1<span class="white--text text-h5">位</span></v-col>
        </v-col>
        <v-col cols="12" sm="7">
            <v-col class="white--text text-h3 text-center">Match Infomation</v-col>
            <v-carousel cycle height="200">
                <v-carousel-item v-for="(match, key, index) in matchs" :key="index">
                    <v-sheet color="black" height="100%" tile>
                        <v-row class="padding_none" align="center" justify="center">
                            <v-col cols="4" sm="5">
                                <v-row class="padding_none" align="center" justify="center">
                                    <v-col cols="12" class="text-center padding_none">
                                        <v-img :src="require(`../assets/${match.home}`)" width="30%" class="ma-auto padding_none"></v-img>
                                    </v-col>
                                    <v-col cols="12" class="white--text text-center padding_none">{{match.homeName}}</v-col>
                                    <v-col cols="12" class="white--text text-center padding_none">{{match.homeResult}}</v-col>
                                    <v-col cols="12" class="text-center padding_none">
                                        <v-img :src="require(`../assets/${match.result}`)" width="20%" class="ma-auto"></v-img>
                                    </v-col>
                                </v-row>
                            </v-col>
                            <v-col cols="4" sm="2">
                                <v-row align="center" justify="center">
                                    <v-col cols="12" class="white--text text-center">{{match.date}}</v-col>
                                    <v-col cols="12" class="text-center text-center">
                                        <v-img :src="require('../assets/Kickoff.png')" width="100%" class="ma-auto"></v-img>
                                    </v-col>
                                    <v-col cols="12" class="white--text text-center">{{match.place}}</v-col>
                                </v-row>
                            </v-col>
                            <v-col cols="4" sm="5">
                                <v-row class="padding_none" align="center" justify="center">
                                    <v-col cols="12" class="text-center padding_none">
                                        <v-img :src="require(`../assets/${match.away}`)" width="30%" class="ma-auto"></v-img>
                                    </v-col>
                                    <v-col cols="12" class="white--text text-center padding_none">{{match.awayName}}</v-col>
                                    <v-col cols="12" class="white--text text-center padding_none">{{match.awayResult}}</v-col>
                                    <v-col cols="12" class="text-center">
                                    </v-col>
                                </v-row>
                            </v-col>
                        </v-row>
                    </v-sheet>
                </v-carousel-item>
            </v-carousel>
        </v-col>
    </v-row>
</template>

<script lang="ts">
    import { Component, Vue } from 'vue-property-decorator';

    @Component({
        components: {

        },
    })
    export default class Home extends Vue {
        data() {
            return {
                matchs: {
                    one: {
                        home: 'dixsept_header_logo.png',
                        away: 'other.png',
                        result: 'win.png',
                        homeResult: '3',
                        awayResult: '0',
                        homeName: 'ディセット浦和',
                        awayName: '対戦相手',
                        place: '富士見体育館',
                        date: 'Sat 14:00'
                    },
                    two: {
                        home: 'dixsept_header_logo.png',
                        away: 'other.png',
                        result: 'lose.png',
                        homeResult: '0',
                        awayResult: '3',
                        homeName: 'ディセット浦和',
                        awayName: '対戦相手',
                        place: '富士見体育館',
                        date: 'Sat 14:00'
                    },
                }
            }
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
        height: auto;
    }
</style>
