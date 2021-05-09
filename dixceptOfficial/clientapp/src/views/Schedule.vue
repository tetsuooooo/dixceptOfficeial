<template>
    <div>
        <v-row>
            <v-col cols="12">
                <v-img :src="require('../assets/NoImg.png')" width="100%" height="40vh"></v-img>
            </v-col>
        </v-row>
        <v-row justify="center">
            <v-col cols="10">
                <v-card>
                    <v-row justify="space-between">
                        <v-col cols="3" class="text-sm-h3 text-h6 text-center">{{year}}</v-col>
                        <v-col cols="6" sm="3">
                            <v-select :items="['','2020','2021']" label="シーズン選択">
                            </v-select>
                        </v-col>
                    </v-row>
                    <hr>
                    <v-row class="mt-5">
                        <v-col cols="12" class="text-sm-h5 text-h6 border_left mt-5 ml-5">埼玉県フットサル2部リーグ</v-col>
                        <v-col cols="12">
                            <v-data-table :headers="headers" :items="items"></v-data-table>
                        </v-col>
                    </v-row>
                </v-card>
            </v-col>
        </v-row>
    </div>
</template>

<script lang="ts">
    import { Component, Vue } from 'vue-property-decorator';

    @Component({
        components: {
            //HelloWorld,
        },
    })
    export default class Shedule extends Vue {
        data() {
            return {
                year: 2021,
                headers: [
                    { text: "節", value: "section", align: "center" },
                    { text: "日付", value: "date", align: "center" },
                    { text: "時間", value: "time", align: "center" },
                    { text: "対戦相手", value: "opponent", align: "center" },
                    { text: "会場", value: "place", align: "center" },
                    { text: "結果", value: "result", align: "center" },
                ],
                items: [
                    { section: '第1節', date: '2021/04/01', time: '10:00', opponent: '九龍FC', place: '宮代体育館', result: '5-7' },
                    { section: '第1節', date: '2021/04/01', time: '10:00', opponent: '九龍FC', place: '宮代体育館', result: '5-7' },
                    { section: '第1節', date: '2021/04/01', time: '10:00', opponent: '九龍FC', place: '宮代体育館', result: '5-7' },
                    { section: '第1節', date: '2021/04/01', time: '10:00', opponent: '九龍FC', place: '宮代体育館', result: '5-7' },
                    { section: '第1節', date: '2021/04/01', time: '10:00', opponent: '九龍FC', place: '宮代体育館', result: '5-7' },
                    { section: '第1節', date: '2021/04/01', time: '10:00', opponent: '九龍FC', place: '宮代体育館', result: '5-7' },
                    { section: '第1節', date: '2021/04/01', time: '10:00', opponent: '九龍FC', place: '宮代体育館', result: '5-7' },
                    { section: '第1節', date: '2021/04/01', time: '10:00', opponent: '九龍FC', place: '宮代体育館', result: '5-7' },
                    { section: '第1節', date: '2021/04/01', time: '10:00', opponent: '九龍FC', place: '宮代体育館', result: '5-7' },
                ],
            }
        }
    }
</script>

<style scoped>
    .border_left {
        border-left: solid 5px green;
    }
</style>
