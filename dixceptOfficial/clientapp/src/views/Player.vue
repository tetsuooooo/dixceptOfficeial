<template>
    <div>
        <v-row>
            <v-col cols="12">
                <v-img :src="require('../assets/NoImg.png')" width="100%" height="40vh"></v-img>
            </v-col>
        </v-row>
        <v-row justify="center">
            <v-col cols="11">
                <v-card>
                    <v-img :src="require('../assets/NoImg.png')" width="100%" height="60vh"></v-img>
                </v-card>
            </v-col>
        </v-row>
        <v-row justify="center">
            <v-col cols="11">
                <v-card>
                    <v-row>
                        <v-col cols="12" sm="3" v-for="(n, index) in 16" :key="index" @click.stop="dialog = true">
                            <v-row justify="center" class="player_detail">
                                <v-col cols="12">
                                    <v-img :src="require('../assets/NoImg.png')" width="100%" contain></v-img>
                                </v-col>
                                <v-col cols="6">
                                    <v-row>
                                        <v-col cols="12" class="text-h3 text-center">10</v-col>
                                        <v-col cols="12" class="text-h4 text-center">Fixo</v-col>
                                    </v-row>
                                </v-col>
                                <v-col cols="6">
                                    <v-row justify="center">
                                        <v-col cols="12" class="subtitle-1 padding_none mt-3">ディセット太郎</v-col>
                                        <v-col cols="12" class="subtitle-2 padding_none">Dixsept Taro</v-col>
                                        <v-col cols="12" class="subtitle-2 padding_none mt-5">2000年12月31日</v-col>
                                        <v-col cols="12" class="subtitle-2 padding_none">170cm/70kg</v-col>
                                    </v-row>
                                </v-col>
                            </v-row>
                        </v-col>
                    </v-row>
                </v-card>
            </v-col>
        </v-row>
        <v-dialog v-model="dialog" max-width="600" height="400">
            <v-card>
                <v-row justify="center" class="mt-3">
                    <v-col cols="11">
                        <v-img :src="require('../assets/NoImg.png')" width="100%" height="300" contain></v-img>
                    </v-col>
                </v-row>
                <v-row justify="center">
                    <v-col cols="11">
                        <v-row>
                            <v-col cols="3" class="text-sm-h3 text-h5 text-center">10</v-col>
                            <v-col cols="9" class="text-sm-h3 text-h5 text-center">サンプル太郎</v-col>
                        </v-row>
                        <v-row>
                            <v-col cols="12">
                                <v-simple-table>
                                    <template v-slot:default>
                                        <tbody>
                                            <tr>
                                                <td class="text-no-wrap">ポジション</td>
                                                <td>Goleiro</td>
                                            </tr>
                                            <tr>
                                                <td class="text-no-wrap">出身地</td>
                                                <td>埼玉県</td>
                                            </tr>
                                            <tr>
                                                <td class="text-no-wrap">生年月日</td>
                                                <td>1995年4月3日</td>
                                            </tr>
                                            <tr>
                                                <td class="text-no-wrap">コメント</td>
                                                <td>
                                                    samplesamplesamplesamplesamplesamplesample
                                                    samplesamplesamplesamplesamplesamplesample
                                                    samplesamplesamplesamplesamplesamplesample
                                                </td>
                                            </tr>
                                        </tbody>
                                    </template>
                                </v-simple-table>
                            </v-col>
                        </v-row>
                    </v-col>
                </v-row>
                <v-card-actions>
                    <v-spacer></v-spacer>
                    <v-btn color="green darken-1" text @click="dialog = false">
                        <v-icon dark left> mdi-arrow-left</v-icon>Back
                    </v-btn>
                </v-card-actions>
            </v-card>
        </v-dialog>
    </div>
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
                dialog: false
            }
        }
    }
</script>

<style>
    /* 選手アニメーション */
    .player_detail {
        cursor: pointer;
        position: relative;
    }

        .player_detail::before,
        .player_detail::after {
            position: absolute;
            z-index: 2;
            content: '';
            width: 0;
            height: 0;
            border: 2px solid transparent;
            box-sizing: content-box;
        }

        .player_detail::before {
            top: -2px;
            left: -2px;
        }

        .player_detail::after {
            bottom: -2px;
            right: -2px;
        }

        .player_detail:hover:before,
        .player_detail:hover::after {
            width: 100%;
            height: 100%;
        }

        .player_detail:hover::before {
            border-bottom-color: #026B2F;
            border-left-color: #026B2F;
            transition: height .3s, width .3s .3s;
        }

        .player_detail:hover::after {
            border-top-color: #026B2F;
            border-right-color: #026B2F;
            transition: height .3s, width .3s .3s;
        }
</style>
