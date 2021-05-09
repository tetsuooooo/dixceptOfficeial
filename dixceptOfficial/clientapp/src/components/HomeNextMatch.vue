<template>
    <v-row>
        <v-col cols="12" class="mt-5">
            <v-sheet class="next_match_bg" tile>
                <v-col cols="12" class="text-sm-h2 text-h5 text-center white--text">Next Match Infomation</v-col>
                <v-row class="padding_none" align="center" justify="center">
                    <!-- ホーム -->
                    <v-col cols="5">
                        <v-row class="padding_none" align="center" justify="center">
                            <v-col cols="12" class="text-center padding_none">
                                <v-img :src="require(`../assets/${match.home}`)" width="60%" class="ma-auto"></v-img>
                            </v-col>
                            <v-col cols="12" class="sp_name_font text-sm-h4 white--text text-center padding_none">{{match.homeName}}</v-col>
                        </v-row>
                    </v-col>
                    <!-- 詳細 -->
                    <v-col cols="2" class="padding_none">
                        <v-row align="center" justify="center">
                            <v-col cols="12" class="white--text text-center text-sm-h4 sp_name_font padding_none">{{match.date}}</v-col>
                            <v-col cols="12" class="text-center text-center padding_none mt-5">
                                <v-img :src="require('../assets/Next-KickOff.png')" width="100%" class="ma-auto"></v-img>
                            </v-col>
                            <v-col cols="12" class="white--text text-center text-sm-h6 sp_name_font padding_none mt-5">{{match.place}}</v-col>
                        </v-row>
                    </v-col>
                    <!-- 相手 -->
                    <v-col cols="5">
                        <v-row class="padding_none" align="center" justify="center">
                            <v-col cols="12" class="text-center padding_none">
                                <v-img :src="require(`../assets/${match.away}`)" width="60%" class="ma-auto"></v-img>
                            </v-col>
                            <v-col cols="12" class="text-sm-h4 sp_name_font white--text text-center padding_none">{{match.awayName}}</v-col>
                        </v-row>
                    </v-col>
                </v-row>
            </v-sheet>
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
                match: {
                    home: 'dixsept_header_logo.png',
                    away: 'other.png',
                    result: 'win.png',
                    homeName: 'ディセット浦和',
                    awayName: '対戦相手',
                    place: '富士見体育館',
                    date: 'Sat 14:00'
                }
            }
        }
    }
</script>

<style scoped>
    .next_match_bg {
        background-color: #026b2f;
        height: 500px;
    }

    @media screen and (max-width: 480px) {
        .next_match_bg {
            height: 200px;
        }

        .sp_name_font {
            font-size: 14px;
            font-weight: bold;
        }
    }
</style>
