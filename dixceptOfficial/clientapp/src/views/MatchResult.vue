<template>
    <v-card>
        <v-row justify="center">
            <v-col cols="10" class="text-h4 boder_left mt-5">埼玉県フットサルリーグ2部リーグ第1節 九龍FC</v-col>
            <v-col cols="10" class="subtitle-2">2020/12/31</v-col>
        </v-row>
        <v-row justify="center">
            <v-col cols="10">
                <v-img :src="require('../assets/NoImg.png')" width="100%" height="60vh"></v-img>
            </v-col>
        </v-row>
        <v-row justify="center">
            <v-col cols="10">
                <v-row justify="center" align-content="center">
                    <v-col cols="3" class="ma-auto">
                        <v-img :src="require('../assets/dixsept_header_logo.png')" width="70%" class="ma-auto"></v-img>
                    </v-col>
                    <v-col cols="4" class="ma-auto">
                        <v-row justify="center">
                            <v-col cols="3" class="text-h1 text-center">0</v-col>
                            <v-row justify="center">
                                <v-col cols="12" class="text-h4 text-center">0-0</v-col>
                                <v-col cols="12" class="text-h4 text-center">0-0</v-col>
                            </v-row>
                            <v-col cols="3" class="text-h1 text-center">0</v-col>
                        </v-row>
                    </v-col>
                    <v-col cols="3" class="ma-auto">
                        <v-img :src="require('../assets/dixsept_header_logo.png')" width="70%" class="ma-auto"></v-img>
                    </v-col>
                </v-row>
                <v-row>
                    <v-col cols="12" class="subtitle-1 text-center">-延長-</v-col>
                    <v-col cols="12" class="text-h4 text-center">0-0</v-col>
                    <v-col cols="12" class="text-h4 text-center">0-0</v-col>
                </v-row>
                <v-row>
                    <v-col cols="12" class="subtitle-1 text-center">-PK-</v-col>
                    <v-col cols="12" class="text-h4 text-center">3-0</v-col>
                </v-row>
                <v-row>
                    <v-col cols="12" class="subtitle-1 text-center">ゴール</v-col>
                    <v-row class="goal_outline">
                        <v-col cols="6">
                            <v-row>
                                <v-col cols="12" class="text-right">
                                    10分 太郎
                                </v-col>
                                <v-col cols="12" class="text-right">
                                    10分 太郎
                                </v-col>
                            </v-row>
                        </v-col>
                        <v-col cols="6" class="boder_left_black">
                            <v-row>
                                <v-col cols="12">
                                    10分 太郎
                                </v-col>
                                <v-col cols="12">
                                    10分 太郎
                                </v-col>
                            </v-row>
                        </v-col>
                    </v-row>
                </v-row>
            </v-col>
            <v-row justify="center" class="mt-5">
            <v-col class="text-center" cols=10>コメント</v-col>
            <v-col cols="10" class="mt-1">
                sample文字列sample文字列sample文字列sample文字列sample文字列sample文字列
                sample文字列sample文字列sample文字列sample文字列sample文字列sample文字列
                sample文字列sample文字列sample文字列sample文字列sample文字列sample文字列
            </v-col>
        </v-row>
        </v-row>
    </v-card>
</template>

<script lang="ts">
    import { Component, Prop, Vue } from 'vue-property-decorator';

    @Component({
        components: {
            //HelloWorld,
        },
    })
    export default class MatchResult extends Vue {
        @Prop({ type: String, required: true })
        id: String
    }
</script>

<style scoped>
    .boder_left {
        border-left: solid 5px green;
    }
    .boder_left_black {
        border-left: solid 1px black;
    }
    .goal_outline{
        border-top: solid 1px black;
        border-bottom: solid 1px black;
    }
</style>
