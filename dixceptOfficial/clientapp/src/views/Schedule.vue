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
                        <v-col cols="3" class="text-h3">{{year}}</v-col>
                        <v-col cols="3">
                            <v-select :items="['','2020','2021']" label="シーズン選択">
                            </v-select>
                        </v-col>
                    </v-row>
                    <hr>
                    <v-row class="mt-5">
                        <v-col cols="12" class="text-h5 border_left mt-5 ml-5">埼玉県フットサル2部リーグ</v-col>
                        <v-col cols="12">
                            <v-simple-table>
                            <template v-slot:default>
                                <thead>
                                    <tr>
                                        <th>節</th>
                                        <th>日付</th>
                                        <th>時間</th>
                                        <th>対戦相手</th>
                                        <th>会場</th>
                                        <th>結果</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td>第1節</td>
                                        <td>4/16</td>
                                        <td>10:00</td>
                                        <td>九龍FC</td>
                                        <td>宮代体育館</td>
                                        <td>5-4</td>
                                    </tr>
                                    <tr>
                                        <td>第2節</td>
                                        <td>5/16</td>
                                        <td>10:00</td>
                                        <td>対戦相手</td>
                                        <td>宮代体育館</td>
                                        <td>-</td>
                                    </tr>
                                </tbody>
                            </template>
                        </v-simple-table>
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
        data(){
            return {
                year: 2021
            }
        }
    }
</script>

<style scoped>
.border_left{
        border-left: solid 5px green;
    }
</style>
