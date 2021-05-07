<template>
    <v-container fluid>
        <v-row>
            <v-col cols="12">
                <v-img :src="require('../assets/NoImg.png')" width="100%" height="40vh"></v-img>
            </v-col>
        </v-row>
        <v-row justify="center">
            <v-col cols="11">
                <v-data-table :headers="headers" :items="items">
                    <template v-slot:item.category="{item}">
                        <v-btn v-if="item.category == 1" color="yellow" elevation="2" outlined small>News</v-btn>
                        <v-btn v-else-if="item.category == 2" color="blue" elevation="2" outlined small>PracticeGame</v-btn>
                        <v-btn v-else-if="item.category == 3" color="red" elevation="2" outlined small>OffcialGame</v-btn>
                    </template>
                    <template v-slot:item.actions="{item}">
                        <v-btn color="green" @click="toNewsDetail(item.category, item.actions)" elevation="2" outlined small>Viewmore</v-btn>
                    </template>
                </v-data-table>
            </v-col>
        </v-row>
    </v-container>
</template>

<script lang="ts">
    import { Component, Vue } from 'vue-property-decorator';

    @Component({
        components: {

        },
    })
    export default class News extends Vue {
        data() {
            return {
                headers: [
                    { text: "日にち", value: "date", align: "center" },
                    { text: "カテゴリー", value: "category", align: "center" },
                    { text: "タイトル", value: "title", align: "center" },
                    { text: "", value: "actions", align: "center" },
                ],
                items: [
                    {
                        date: '2021/04/01',
                        category: 1,
                        title: 'お知らせ',
                        actions: 1
                    },
                    {
                        date: '2021/04/01',
                        category: 2,
                        title: '今日の試合',
                        actions: 2
                    },
                    {
                        date: '2021/04/01',
                        category: 3,
                        title: '公式戦',
                        actions: 3
                    },
                    {
                        date: '2021/04/01',
                        category: 1,
                        title: 'お知らせ',
                        actions: 1
                    },
                    {
                        date: '2021/04/01',
                        category: 2,
                        title: '今日の試合',
                        actions: 2
                    },
                    {
                        date: '2021/04/01',
                        category: 3,
                        title: '公式戦',
                        actions: 3
                    },
                    {
                        date: '2021/04/01',
                        category: 1,
                        title: 'お知らせ',
                        actions: 1
                    },
                    {
                        date: '2021/04/01',
                        category: 2,
                        title: '今日の試合',
                        actions: 2
                    },
                    {
                        date: '2021/04/01',
                        category: 3,
                        title: '公式戦',
                        actions: 3
                    },
                ]
            }
        }
        toNewsDetail(category: string, id: string) {
            // Enum使たほうがいいかも
            let path: string = "/";
            if (category == "1") {
                path = "news-detail";
            } else if (category == "2") {
                path = "training";
            } else if (category == "3") {
                path = "match-result";
            }
            this.$router.push({
                name: path,
                params: { id: id }
            })
        }
    }
</script>

<style scoped>

</style>
